using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02_ARRAYS_Bunny_Factory
{
    class BunnyFactory
    {
        static void Main()
        {
            var list = new List<string>();
            string inputInt = "";
            string result = "";
            int cycleCounter = 1;

            //get the input data
            while (inputInt != "END")
            {
                inputInt = Console.ReadLine();
                if (inputInt != "END")
                {
                    list.Add(inputInt);
                }
            }


            //starting position
            int cycleEnd = Convert.ToInt32(list[0]);


            while (cycleEnd <= Convert.ToInt32(list.Count) - 1)
            {
                if (cycleCounter == 1)
                {
                    cycleEnd = Convert.ToInt32(list[0]);
                }
                else
                {
                    cycleEnd = 0;
                    for (int i = 0; i < cycleCounter; i++)
                    {
                        cycleEnd += Convert.ToInt32(list[i]);
                    }
                }

                //if there are not enough numbers in the list, print the original input
                if (cycleEnd > list.Count)
                {
                    break;
                }

                BigInteger sum = 0;
                BigInteger product = 1;
                StringBuilder sb = new StringBuilder();
                string firstPart = "";
                string remainder = "";

                
                for (int i = cycleCounter, counter = 0; counter < cycleEnd; i++, counter++)
                {
                    sum += Convert.ToUInt64(list[i]);
                }

                for (int i = cycleCounter, counter = 0; counter < cycleEnd; i++, counter++)
                {
                    product *= Convert.ToUInt64(list[i]);
                }
                sb.Append(sum.ToString());
                sb.Append(product.ToString());
                firstPart = sb.ToString();

                for (int i = cycleCounter + cycleEnd; i < Convert.ToInt32(list.Count); i++)
                {
                    sb.Append(list[i]);
                }
                remainder = sb.ToString();
                sb.Clear();

                list.Clear();

                for (int i = 0; i < Convert.ToInt32(remainder.Length); i++)
                {
                    if (remainder[i] != '1' & remainder[i] != '0')
                    {
                        list.Add(remainder[i].ToString());
                    }
                }
                result = String.Join(" ", list.Select(x => x.ToString()).ToArray());
                cycleCounter++;
            }

            //if there are not enough numbers in the list, print the original input
            if (cycleEnd > list.Count-1)
            {
                result = String.Join(" ", list.Select(x => x.ToString()).ToArray());
                Console.WriteLine(result);
            }
        }
    }
}
