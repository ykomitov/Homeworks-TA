using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ones_and_Zeros
{
    class OnesAndZeros
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string inputBin = Convert.ToString(input, 2).PadLeft(32, '0');
            string inputLastBits = inputBin.Substring(16);

            //Get row 1 of the output
            for (int i = 0; i < 16; i++)
            {
                if (i < 15)
                {
                    if (inputLastBits[i] == '0')
                    {
                        Console.Write("###.");
                    }
                    else
                    {
                        Console.Write(".#..");
                    }

                }
                if (i == 15)
                {
                    if (inputLastBits[i] == '0')
                    {
                        Console.WriteLine("###");
                    }
                    else
                    {
                        Console.WriteLine(".#.");
                    }
                }
            }

            //Get row 2 of the output
            for (int i = 0; i < 16; i++)
            {
                if (i < 15)
                {
                    if (inputLastBits[i] == '0')
                    {
                        Console.Write("#.#.");
                    }
                    else
                    {
                        Console.Write("##..");
                    }

                }
                if (i == 15)
                {
                    if (inputLastBits[i] == '0')
                    {
                        Console.WriteLine("#.#");
                    }
                    else
                    {
                        Console.WriteLine("##.");
                    }
                }
            }

            //Get row 3 & 4 of the output
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (i < 15)
                    {
                        if (inputLastBits[i] == '0')
                        {
                            Console.Write("#.#.");
                        }
                        else
                        {
                            Console.Write(".#..");
                        }

                    }
                    if (i == 15)
                    {
                        if (inputLastBits[i] == '0')
                        {
                            Console.WriteLine("#.#");
                        }
                        else
                        {
                            Console.WriteLine(".#.");
                        }
                    }
                }

            }
            //row 5
            Console.WriteLine("###.###.###.###.###.###.###.###.###.###.###.###.###.###.###.###");
        }
    }
}
