//Write a program that reads a year from the console and checks whether it is a leap one. Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        //Get user input
        Console.Write("Please enter an year (format YYYY): ");
        int year = int.Parse(Console.ReadLine());

        //Check if the year is leap
        bool isLeap = DateTime.IsLeapYear(year);
        
        //Print result on the console
        if (isLeap)
        {
            Console.WriteLine("\r\n{0} is a leap year.\r\n", year);
        }
        else
        {
            Console.WriteLine("\r\n{0} is NOT a leap year.\r\n", year);
        }
        
    }
}

