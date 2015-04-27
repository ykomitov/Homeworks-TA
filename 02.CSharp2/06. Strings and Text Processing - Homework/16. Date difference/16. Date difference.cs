//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

/*  Enter the first date: 27.02.2006
    Enter the second date: 3.03.2006
    Distance: 4 days*/

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        //Get the two dates from the console
        Console.Write("Enter the first date in format d.MM.yyyy: ");
        string firstDate = Console.ReadLine();
        DateTime firstDateDT = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();
        DateTime secondDateDT = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

        //Calculate time span ts
        TimeSpan ts = secondDateDT - firstDateDT;

        //Print result
        Console.WriteLine("\r\nDistance: {0} days", ts.Days);
    }
}

