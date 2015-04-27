using System;

/*	Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
	*	Use a sequence of `if` operators.

_Examples:_

| a    | b    | c    | result |
|------|------|------|:------:|
| 5    | 2    | 2    | +      |
| -2   | -2   | 1    | +      |
| -2   | 4    | 3    | -      |
| 0    | -2.5 | 4    | 0      |
| -1   | -0.5 | -5.1 | -      |*/

    class MultiplicationSign
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            /*Всичко може да се напише в 3 if-а:
                 * един за 0
                 * един съдържащ всички условия, които дават +
                 * един за минусите
             ...като условията (в скоби) са разделени с ||, но мисля, че така се чете по-лесно и затова го оставям така.*/

            if (a == 0 || b == 0 || c == 0) //Check if any of the 3 numbers is 0
            {
                Console.WriteLine("0");
            }
            if (a > 0 && b > 0 && c > 0) //Check if all 3 numbers are positive
            {
                Console.WriteLine("+");
            }
            if (a < 0 && b < 0 && c < 0) //Check if all 3 numbers are negative
            {
                Console.WriteLine("-");
            }
            if (a < 0 && b < 0 && c > 0) //Check if a & b are negative & c is positive
            {
                Console.WriteLine("+");
            }
            if (a < 0 && b > 0 && c < 0) //Check if a & c are negative & b is positive
            {
                Console.WriteLine("+");
            }
            if (a > 0 && b < 0 && c < 0) //Check if b & c are negative & a is positive
            {
                Console.WriteLine("+");
            }
            if (a < 0 && b > 0 && c > 0) //Check if a is negative, b & c positive
            {
                Console.WriteLine("-");
            }
            if (a > 0 && b < 0 && c > 0) //Check if b is negative, a & c positive
            {
                Console.WriteLine("-");
            }
            if (a > 0 && b > 0 && c < 0) //Check if c is negative, a & b positive
            {
                Console.WriteLine("-");
            }
        }
    }