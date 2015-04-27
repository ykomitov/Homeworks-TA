/*•	Write a method that calculates the number of workdays between today and given date, passed as parameter.
  •	Workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

using System;
using System.Globalization;

class Workdays
{
    static void Main()
    {
        //Get the end date from the console
        Console.Write("Please enter the end date in format dd.MM.yyyy: ");
        string date = Console.ReadLine();
        DateTime endDate = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Between today and {0:dd.MM.yyyy} there are {1} working days.", endDate, CalculateWorkdays(endDate));
    }

    static int CalculateWorkdays(DateTime endDate)
    {
        //Array with public holidays in 2015
        DateTime[] publicHolidays = 
        {
            new DateTime(2015, 03, 2),
            new DateTime(2015, 03, 3),
            new DateTime(2015, 04, 10),
            new DateTime(2015, 04, 13),
            new DateTime(2015, 05, 6),
            new DateTime(2015, 09, 21),
            new DateTime(2015, 09, 22),
            new DateTime(2015, 12, 24),
            new DateTime(2015, 12, 25),
            new DateTime(2015, 12, 31),
        };

        //Count the workdays and official holidays between today & end date
        int workdays = 0;
        int publicHolidaysCounter = 0;

        //DateTime day = new DateTime();
        for (DateTime day = DateTime.Now; day.Date < endDate.Date; day = day.AddDays(1))
        {
            if ((day.DayOfWeek != DayOfWeek.Saturday) && (day.DayOfWeek != DayOfWeek.Sunday))
            {
                workdays++;
            }
            if (Array.IndexOf(publicHolidays, day.DayOfWeek) != -1)
            {
                publicHolidaysCounter++;
            }
        }

        //Returt the final result - working days minus official holidays
        return (workdays - publicHolidaysCounter);
    }
}

