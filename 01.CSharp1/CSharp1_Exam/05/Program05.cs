using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

class Program05
{
    static void Main()
    {
        byte s = byte.Parse(Console.ReadLine());
        string sString = Convert.ToString(s, 2).PadLeft(5, '0');
        byte n = byte.Parse(Console.ReadLine());
        string line;
        string lineBit = "";
        string input = "";
        string source = "";
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            line = Console.ReadLine();
            lineBit = Convert.ToString(Convert.ToInt32(line), 2).PadLeft(29, '0');
            input = input + " " + lineBit;
        }
        string[] arrayInput = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < arrayInput.Length; i++)
        {

            source = arrayInput[i];
            //count += Regex.Matches(source, sString).Count;

            for (int k = 0; k <= source.Length - sString.Length; k++)
            {
                if (source.Substring(k, sString.Length) == sString)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}
