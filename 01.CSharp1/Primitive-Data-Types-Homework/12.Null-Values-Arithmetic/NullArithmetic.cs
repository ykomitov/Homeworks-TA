﻿using System;

/*  *	Create a program that assigns null values to an integer and to a double variable. 
    *	Try to print these variables at the console. 
    *	Try to add some number or the null literal to these variables and print the result.*/

class NullArithmetic
{
    static void Main()
    {
        int? iNull = null;
        double? dNull = null;

        Console.WriteLine(iNull);
        Console.WriteLine(dNull);

        iNull = 5;
        dNull = 10;

        Console.WriteLine(iNull);
        Console.WriteLine(dNull);
    }
}
