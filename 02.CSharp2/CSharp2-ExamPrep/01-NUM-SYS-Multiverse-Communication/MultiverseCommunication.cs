using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MultiverseCommunication
{
    static void Main()
    {
        string input = Console.ReadLine();
        //string input = "TELERIK-ACADEMY";

        string[] inputArr = new string[(input.Length) / 3];
        string[] numSystem = new string[(input.Length) / 3];

        int chunkSize = 3;
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
                case "CHU": numSystem[i] = "0"; break;
                case "TEL": numSystem[i] = "1"; break;
                case "OFT": numSystem[i] = "2"; break;
                case "IVA": numSystem[i] = "3"; break;
                case "EMY": numSystem[i] = "4"; break;
                case "VNB": numSystem[i] = "5"; break;
                case "POQ": numSystem[i] = "6"; break;
                case "ERI": numSystem[i] = "7"; break;
                case "CAD": numSystem[i] = "8"; break;
                case "K-A": numSystem[i] = "9"; break;
                case "IIA": numSystem[i] = "A"; break;
                case "YLO": numSystem[i] = "B"; break;
                case "PLA": numSystem[i] = "C"; break;
                default: break;
            }
        }

        StringBuilder builder = new StringBuilder();
        foreach (string value in numSystem)
        {
            builder.Append(value);
        }
        string numToConvert = builder.ToString();

        Console.WriteLine(ConvertNumberSystem(numToConvert, 13, 10));
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

