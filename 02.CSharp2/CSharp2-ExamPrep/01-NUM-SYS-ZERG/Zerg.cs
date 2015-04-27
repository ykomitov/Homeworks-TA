using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MultiverseCommunication
{
    static void Main()
    {
        int chunkSize = 4;
        int numSystemToTransform = 15;

        string input = Console.ReadLine();
        //string input = "HsstSsstSsst";

        string[] inputArr = new string[(input.Length) / chunkSize];
        string[] numSystem = new string[(input.Length) / chunkSize];


        int stringLength = input.Length;
        for (int i = 0, j = 0; i < stringLength; i += chunkSize, j++)
        {
            if (i + chunkSize <= stringLength)
            {
                inputArr[j] = input.Substring(i, chunkSize);
            }
        }

        for (int i = 0; i < inputArr.Length; i++)
        {
            switch (inputArr[i].ToString())
            {
                case "Rawr": numSystem[i] = "0"; break;
                case "Rrrr": numSystem[i] = "1"; break;
                case "Hsst": numSystem[i] = "2"; break;
                case "Ssst": numSystem[i] = "3"; break;
                case "Grrr": numSystem[i] = "4"; break;
                case "Rarr": numSystem[i] = "5"; break;
                case "Mrrr": numSystem[i] = "6"; break;
                case "Psst": numSystem[i] = "7"; break;
                case "Uaah": numSystem[i] = "8"; break;
                case "Uaha": numSystem[i] = "9"; break;
                case "Zzzz": numSystem[i] = "A"; break;
                case "Bauu": numSystem[i] = "B"; break;
                case "Djav": numSystem[i] = "C"; break;
                case "Myau": numSystem[i] = "D"; break;
                case "Gruh": numSystem[i] = "E"; break;
                default: break;
            }
        }

        StringBuilder builder = new StringBuilder();
        foreach (string value in numSystem)
        {
            builder.Append(value);
        }
        string numToConvert = builder.ToString();

        Console.WriteLine(ConvertNumberSystem(numToConvert, numSystemToTransform, 10));
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
        return decRepresentation.ToString();
    }
}

