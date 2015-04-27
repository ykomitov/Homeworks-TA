using System;

//Write a program that prints an isosceles triangle of 9 copyright symbols `©`, something like this

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; //Sets console output to UTF8

        string a = " ";
        string b = "©";

        Console.WriteLine("{0}{0}{0}{1}{0}{0}{0}", a, b);
        Console.WriteLine("{0}{0}{1}{0}{1}{0}{0}", a, b);
        Console.WriteLine("{0}{1}{0}{0}{0}{1}{0}", a, b);
        Console.WriteLine("{1}{0}{1}{0}{1}{0}{1}", a, b);
    }
}
