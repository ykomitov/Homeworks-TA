//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and</upcase> to upper-case.
//The tags cannot be nested.

/*Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/

using System;
using System.Text.RegularExpressions;

class ParseTags
{
    static void Main()
    {
        string initialString = "We are living in a <upcase>yellow submarine</upcase>, <upcase>yellow submarine</upcase>, <upcase>yellow submarine submarine</upcase>.";

        //Print the initial string
        Console.WriteLine("String before change:");
        Console.WriteLine("\t{0}", initialString);
        Console.WriteLine();

        while (true)
        {
            int substringStart = initialString.IndexOf("<upcase>") + "<upcase>".Length;
            int substringLength = initialString.IndexOf("</upcase>") - substringStart;
            bool run = substringLength > 0;

            //Break the loop if no </upcase> tag is found
            if (run == false)
            {
                break;
            }

            //Find substring between <upcase> ... </upcase> & change it to uppercase
            string substring = initialString.Substring(substringStart, substringLength);
            string substringUpper = substring.ToUpper();

            //Replace original substring with uppercase substring

            initialString = Regex.Replace(initialString, substring, substringUpper);
            Regex replaceUpcaseStart = new Regex("<upcase>");
            Regex replaceUpcaseEnd = new Regex("</upcase>");
            initialString = replaceUpcaseStart.Replace(initialString, "", 1);
            initialString = replaceUpcaseEnd.Replace(initialString, "", 1);
        }

        //Print the end string
        Console.WriteLine("String after change:");
        Console.WriteLine("\t{0}", initialString);
        Console.WriteLine();
    }
}

