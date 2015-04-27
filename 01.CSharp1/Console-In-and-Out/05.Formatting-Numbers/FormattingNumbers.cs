using System;

/**	Write a program that reads 3 numbers:
	*	integer `a` (0 <= a <= 500)
	*	floating-point `b`
	*	floating-point `c` 
*	The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.	
	*	The number `a` should be printed in hexadecimal, left aligned
	*	Then the number `a` should be printed in binary form, padded with zeroes
	*	The number `b` should be printed with 2 digits after the decimal point, right aligned
	*	The number c should be printed with 3 digits after the decimal point, left aligned. 
	
_Examples:_

|  a  |    b    |    c    |                      result                    |
|:---:|:-------:|:-------:|------------------------------------------------|
| 254 | 11.6    | 0.5     | `FE        |0011111110|     11.60|0.500     |` |
| 499 | -0.5559 | 10000   | `1F3       |0111110011|     -0.56|10000     |` |
| 0   | 3       | -0.1234 | `0         |0000000000|         3|-0.123    |` |*/

class FormattingNumbers
{
    static void Main()
    {
        char pad = ' '; //Padding char 'space'
        char padZero = '0'; //Padding char '0' - for the bin padding
       
        //Read the numbers from the console
        Console.Write("Please enter number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter number c: ");
        double c = double.Parse(Console.ReadLine());
        
        //Convert the numbers to strings with appropriate format
        string aHex = String.Format("{0:X}", a); //int a to hex
        string aByte = Convert.ToString(a, 2); //int a to binary
        string bRound = Convert.ToString(Math.Round(b, 2)); //round b to 2 digits after decimal
        string cRound = Convert.ToString(Math.Round(c, 3)); //round c to 3 digits after decimal

        //Print result on the console
        Console.WriteLine("\r\n|{0}|{1}|{2}|{3}|\r\n", aHex.PadRight(11, pad), aByte.PadLeft(10, padZero), bRound.PadLeft(10, pad), cRound.PadRight(10, pad));
    }
}
