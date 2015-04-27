using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int eggHeight = 2 * n;
        int eggWidht = 3 * n - 1;
        int drawingArea = 3 * n + 1;
        int topBottom = n - 1;
        int outer = 1;
        int inner = 1;

        //Print top of the egg
        string eggTop =
            new string('.', n + 1) +
            new string('*', n - 1) +
            new string('.', n + 1);

        Console.WriteLine(eggTop);

        //Print top part above the crack
        for (int i = 0; i < n - 2; i++)
        {
            string topPart =
                new string('.', n - outer) +
                "*" +
                new string('.', n + inner) +
                "*" +
                new string('.', n - outer);
            if (n - outer > 1)
            {
                outer += 2;
                inner += 4;
            }
            Console.WriteLine(topPart);
        }

        //Print the 2 cracked rows in the middle
        Console.Write(".*");
        for (int j = 2; j <= eggWidht - 1; j++)
        {
            if (j % 2 == 0)
            {
                Console.Write("@");
            }
            else if (j % 2 != 0)
            {
                Console.Write(".");
            }
        }
        Console.WriteLine("*.");

        Console.Write(".*");
        for (int k = 2; k <= eggWidht - 1; k++)
        {
            if (k % 2 == 0)
            {
                Console.Write(".");
            }
            else if (k % 2 != 0)
            {
                Console.Write("@");
            }
        }
        Console.WriteLine("*.");

        //Print bottom part below the crack
        for (int l = 0; l < n - 2; l++)
        {
            string topPart =
                new string('.', n - outer) +
                "*" +
                new string('.', n + inner) +
                "*" +
                new string('.', n - outer);
            if (l > (n - 2)/2-2)
            {
                outer -= 2;
                inner -= 4;
            }
            Console.WriteLine(topPart);
        }

        //Print bottom of the egg
        string eggBottom =
            new string('.', n + 1) +
            new string('*', n - 1) +
            new string('.', n + 1);

        Console.WriteLine(eggBottom);
    }
}
