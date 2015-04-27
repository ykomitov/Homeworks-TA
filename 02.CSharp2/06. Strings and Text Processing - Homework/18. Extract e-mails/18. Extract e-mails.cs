//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.

using System;
using System.Text.RegularExpressions;
using System.Linq;

class ExtractEMails
{
    static void Main()
    {
        string input = "vessela <vessie@abv.bg> sadlm asdal test-email@dir.bg kda vor Mitov <Adam@Gmail.com asdkl asd;k asd ;asd";

        Console.WriteLine("Input string: {0}\r\n", input);

        //Extract all vald emails to a string array
        string[] emailCollection = Regex.Matches(input, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
                                                .Cast<Match>()
                                                .Select(m => m.Value)
                                                .ToArray();

        //Print extracted emails
        foreach (var email in emailCollection)
        {
            Console.WriteLine(email);
        }

        Console.WriteLine();
    }
}

