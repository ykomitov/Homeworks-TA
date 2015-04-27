using System;

/*  *	Declare two string variables and assign them with following value: `The "use" of quotations causes difficulties.`
    *	Do the above in two different ways - with and without using quoted strings.
    *	Print the variables to ensure that their value was correctly defined.*/

class QuotesInStrings
{
    static void Main()
    {
        string quotedString = @"The ""use"" of quotations causes difficulties.";
        string noQuotedString = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine(quotedString);
        Console.WriteLine(noQuotedString);
    }
}
