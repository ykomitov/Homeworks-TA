﻿using System;

/**	Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
	*	Calculates the sum of the digits (in our example `2 + 0 + 1 + 1 = 4`).
	*	Prints on the console the number in reversed order: `dcba` (in our example `1102`).
	*	Puts the last digit in the first position: `dabc` (in our example `1201`).
	*	Exchanges the second and the third digits: `acbd` (in our example `2101`).
 
 The number has always exactly 4 digits and cannot start with 0.

_Examples:_

|    n    | sum of digits | reversed | last digit in front | second and third digits exchanged |
|:-------:|:-------------:|:--------:|:-------------------:|:---------------------------------:|
| 2011    | 4             | 1102     | 1201                | 2101                              |
| 3333    | 12            | 3333     | 3333                | 3333                              |
| 9876    | 30            | 6789     | 6987                | 9786                              |*/

class FourDigits
{
    static void Main()
    {
        Console.Write("Please enter a 4 digit number: ");
        string number = Console.ReadLine();
        int a = Convert.ToInt16(number[0].ToString());
        int b = Convert.ToInt16(number[1].ToString());
        int c = Convert.ToInt16(number[2].ToString());
        int d = Convert.ToInt16(number[3].ToString());

        Console.WriteLine("Sum of the digits: " + (a + b + c + d));
        Console.WriteLine("Reversed: " + d + c + b + a);
        Console.WriteLine("Last digit in the first position: " + d + a + b + c);
        Console.WriteLine("Exchange the second and the third digits: " + a + c + b + d);
    }
}
