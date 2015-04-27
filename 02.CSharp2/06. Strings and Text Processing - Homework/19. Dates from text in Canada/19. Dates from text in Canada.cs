/*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
  Display them in the standard date format for Canada.*/

using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

class DatesFromTextInCanada
{
    static void Main()
    {
        //Set culture to en-CA
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        CultureInfo canada = Thread.CurrentThread.CurrentCulture;

        string input = "vessela <vessie@abv.bg> 02.30.2013 sadlm asdal 02.12.2014 test-email@dir.bg kda vor Mitov <Adam@Gmail.com asdkl asd;k asd ;asd";

        Console.WriteLine("Input string: {0}\r\n", input);

        //Extract all valid & invalid dates in format DD.MM.YYYY to a string array
        string format = "d.M.yyyy";
        string expression = @"[\d]{1,2}.[\d]{1,2}.[\d]{4}";

        string[] dateCollection = Regex.Matches(input, expression)
                                                .Cast<Match>()
                                                .Select(m => m.Value)
                                                .ToArray();

        //Parse valid dates in a list
        List<DateTime> validDates = new List<DateTime>();
        foreach (string date in dateCollection)
        {
            try
            {
                DateTime check = DateTime.ParseExact(date.ToString(), format, canada);
                validDates.Add(check);
            }
            catch (FormatException)
            {
                continue;
            }
        }

        //Print all valid dates in format d/M/yyyy
        foreach (var validDate in validDates)
        {
            Console.WriteLine(validDate.ToString("d/M/yyyy"));
        }
    }
}

