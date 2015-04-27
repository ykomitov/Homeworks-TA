using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Boats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int boatWidth = 2 * n + 1;
        int boatHeight = 6 + ((n - 3) / 2) * 3;
        int sales = 2 * boatHeight / 3;
        int outerDot = 2;
        int innerDot = 1;

        //Print the sale of the boat with the first loop

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                string top =
                    new string('.', n) +
                    "*" +
                    new string('.', n);
                Console.WriteLine(top);
            }
            else if (i == 1)
            {
                string second =
                    new string('.', n - 1) +
                    new string('*', 3) +
                    new string('.', n - 1);
                Console.WriteLine(second);
            }
            else if (i > 1)
            {
                string thirdOn =
                    new string('.', n - outerDot) +
                    new string('*', 1) +
                    new string('.', innerDot) +
                    new string('*', 1) +
                    new string('.', innerDot) +
                    new string('*', 1) +
                    new string('.', n - outerDot);
                outerDot++;
                innerDot++;
                Console.WriteLine(thirdOn);
            }
        }

        //Print the full line of "*" - the top of the boat

        string topOfBoat = new string('*', boatWidth);
        Console.WriteLine(topOfBoat);
        outerDot--;
        innerDot--;

        //Print the boat

        for (int j = 0; j < (boatHeight - n - 2); j++)
        {
            string boatBody =
                    new string('.', n - outerDot) +
                    new string('*', 1) +
                    new string('.', innerDot) +
                    new string('*', 1) +
                    new string('.', innerDot) +
                    new string('*', 1) +
                    new string('.', n - outerDot);
            outerDot--;
            innerDot--;
            Console.WriteLine(boatBody);
        }

        //Print the boat bottom

        string boatBottom =
                   new string('.', n - outerDot) +
                   new string('*', n) +
                   new string('.', n - outerDot);
        Console.WriteLine(boatBottom);
    }
}