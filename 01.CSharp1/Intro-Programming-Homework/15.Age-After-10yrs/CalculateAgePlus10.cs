using System;

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years

class CalculateAgePlus10
{
    static void Main(string[] args)
    {

        DateTime birthday;
        DateTime today = DateTime.Today;

        Console.Write("Please enter your birthday in format dd.mm.yyyy: ");
        string dateInput = Console.ReadLine();
        DateTime.TryParse(dateInput, out birthday);

        int age = today.Year - birthday.Year;

        if (birthday > today.AddYears(-age)) //Check if this year's birthday is still pending
        {
            age--;
        }

        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("After 10 years you'll be {0}.", (age + 10));
    }
}
