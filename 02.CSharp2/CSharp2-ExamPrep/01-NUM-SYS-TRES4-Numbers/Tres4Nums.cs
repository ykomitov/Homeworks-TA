using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01_NUM_SYS_TRES4_Numbers
{
    class Tres4Nums
    {
        static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            string value = input.ToString();

            //Num system start
            int s = 10;

            //Targeted num system
            int d = 9;

            string output = ConvertNumberSystem(value, s, d);

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < output.Length; i++)
            {
                switch (output[i])
                {
                    case '0': builder.Append("LON+"); break;
                    case '1': builder.Append("VK-"); break;
                    case '2': builder.Append("*ACAD"); break;
                    case '3': builder.Append("^MIM"); break;
                    case '4': builder.Append("ERIK|"); break;
                    case '5': builder.Append("SEY&"); break;
                    case '6': builder.Append("EMY>>"); break;
                    case '7': builder.Append("/TEL"); break;
                    case '8': builder.Append("<<DON"); break;
                    default: break;
                }
            }

            string result = builder.ToString();
            Console.WriteLine(result);
        }

        static string ConvertNumberSystem(string value, int base1, int base2)
        {
            ulong decRepresentation = 0;
            // Convert from any number base to decimal
            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(value[i]))
                {
                    decRepresentation += (ulong)((value[i] - '0') * Math.Pow(base1, value.Length - i - 1));
                }
                else
                {
                    int num = 0;
                    switch (value[i])
                    {
                        case 'a':
                        case 'A':
                            num = 10;
                            break;
                        case 'b':
                        case 'B':
                            num = 11;
                            break;
                        case 'c':
                        case 'C':
                            num = 12;
                            break;
                        case 'd':
                        case 'D':
                            num = 13;
                            break;
                        case 'e':
                        case 'E':
                            num = 14;
                            break;
                        case 'f':
                        case 'F':
                            num = 15;
                            break;
                        default:
                            break;
                    }
                    decRepresentation += (ulong)(num * Math.Pow(base1, value.Length - i - 1));
                }
            }

            // Convert from decimal to other number bases 
            ulong remainder;
            string result = string.Empty;
            if (decRepresentation != 0)
            {
                while (decRepresentation > 0)
                {
                    remainder = (ulong)(decRepresentation % (ulong)base2);
                    decRepresentation /= (ulong)base2;
                    if (remainder < 10)
                    {
                        result = remainder.ToString() + result;
                    }
                    else
                    {
                        switch (remainder)
                        {
                            case 10:
                                result = "A" + result;
                                break;
                            case 11:
                                result = "B" + result;
                                break;
                            case 12:
                                result = "C" + result;
                                break;
                            case 13:
                                result = "D" + result;
                                break;
                            case 14:
                                result = "E" + result;
                                break;
                            case 15:
                                result = "F" + result;
                                break;
                            default:
                                break;
                        }
                    }
                }
                return result;
            }
            else
            {
                return "0";
            }
        }
    }
}
