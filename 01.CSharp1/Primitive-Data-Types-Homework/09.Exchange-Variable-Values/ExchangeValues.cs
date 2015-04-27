using System;

/*Declare two integer variables `a` and `b` and assign them with `5` and `10` and after that exchange their values by using some programming logic. Print the variable values before and after the exchange.*/

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int swap;

        Console.WriteLine("Before swap value of a = " + a);
        Console.WriteLine("Before swap value of b = " + b);
        Console.WriteLine("\r\nSwapping a and b...\r\n");
        swap = a;
        a = b;
        b = swap;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

    }
}