//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Numerics;

class HexToDec
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string hexNum = Console.ReadLine();
        long decimalNum = 0;
        string input = "";
        string builder = "";
        for (int i = 0; i < hexNum.Length; i++)
        {

            //Hexadecimal is easily converted into binary format, then we can use the code from Problem N13 ;)
            switch (hexNum[i].ToString())
            {
                case "0": builder = "0000"; break;
                case "1": builder = "0001"; break;
                case "2": builder = "0010"; break;
                case "3": builder = "0011"; break;
                case "4": builder = "0100"; break;
                case "5": builder = "0101"; break;
                case "6": builder = "0110"; break;
                case "7": builder = "0111"; break;
                case "8": builder = "1000"; break;
                case "9": builder = "1001"; break;
                case "A": builder = "1010"; break;
                case "B": builder = "1011"; break;
                case "C": builder = "1100"; break;
                case "D": builder = "1101"; break;
                case "E": builder = "1110"; break;
                case "F": builder = "1111"; break;
                default: break;
            }
            input += builder;
        }

        //Convert binary to decimal
        for (int i = 0; i < input.Length; i++)
        {
            if ((input[i] - '0') == 1)
            {
                decimalNum += ((input[i] - '0') * (long)BigInteger.Pow(2, (input.Length - i - 1)));
            }
        }
        Console.WriteLine("The hexadecimal number {0} is {1} in decimal.", hexNum, decimalNum);
    }
}

