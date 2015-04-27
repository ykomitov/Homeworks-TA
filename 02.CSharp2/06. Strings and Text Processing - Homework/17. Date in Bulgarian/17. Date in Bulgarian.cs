/* Write a program that reads a date and time given in the format:
 * day.month.year hour:minute:second and prints the date and time 
 * after 6 hours and 30 minutes (in the same format) along with the 
 * day of week in Bulgarian.*/

using System;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        //Set console to Bulgarian
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        CultureInfo bulgarian = new CultureInfo("bg-BG");
        
        //Get the date from the console
        Console.Write("Enter the first date in format d.M.yyyy H:mm:ss: ");
        string firstDate = Console.ReadLine();
        DateTime firstDateDT = DateTime.ParseExact(firstDate, "d.M.yyyy H:mm:ss", CultureInfo.InvariantCulture);

        Console.WriteLine(firstDateDT);

        //Add 6 h 30 min
        DateTime newDateTime = firstDateDT.AddHours(6).AddMinutes(30);

        Console.WriteLine("{0} {1}", newDateTime, newDateTime.ToString("dddd"));
    }
}
