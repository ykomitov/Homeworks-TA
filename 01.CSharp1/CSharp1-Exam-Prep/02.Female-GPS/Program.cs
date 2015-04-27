using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Female_GPS
{
    class Program
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            long inputAbs = Math.Abs(input);
            string inputStr = inputAbs.ToString();
            long sumEven = 0;
            long sumOdd = 0;

            for (int i = 0; i < inputStr.Length; i++)
            {
                if ((int)Char.GetNumericValue(inputStr[i]) % 2 == 0)
                {
                    sumEven += (int)Char.GetNumericValue(inputStr[i]);
                }
                else
                {
                    sumOdd += (int)Char.GetNumericValue(inputStr[i]);
                }
            }

            if (sumEven > sumOdd)
            {
                Console.WriteLine("right {0}", sumEven);
            }
            else if (sumEven < sumOdd)
            {
                Console.WriteLine("left {0}", sumOdd);
            }
            else if (sumEven == sumOdd)
            {
                Console.WriteLine("straight {0}", sumOdd);
            }
        }
    }
}
