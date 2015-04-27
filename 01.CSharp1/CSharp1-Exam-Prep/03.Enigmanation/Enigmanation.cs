using System;
using System.Data;

class Enigmanation
{
    static void Main()
    {
        string input = Console.ReadLine();
        string input2 = input.Remove(input.Length - 1);

        DataTable dt = new DataTable();
        var v = dt.Compute(input2, "");

        Console.WriteLine("{0:0.000}", v);


    }

}
