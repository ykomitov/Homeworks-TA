//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main()
    {            
        //while (true)
        //{
        //Console.Write("Please enter a binary number: ");
        //string binNum = Console.ReadLine();

        //Some tests
        //string binNum = "10011010101001";                  //HEX: 26A9
        string binNum = "000100001";                      //HEX: 221
        //string binNum = "10101010111100110111101111";      //HEX: 2ABCDEF
        //string binNum = "110100001100";                    //HEX: D0C
        //string binNum = "1001000110100010101100111100010010000101010111100110111101111"; //HEX: 1234567890ABCDEF

        //Initialize an array to hold the binary digits
        string[] arrayBin = new string[binNum.Length * 4];

        //Fill the binary number with zeros to be divisible by 4
        int fill = 0;
        if (binNum.Length % 4 != 0)
        {
            fill = 4 - (binNum.Length % 4);
        }
        string fillString = new String('0', fill);
        string properString = fillString + binNum;

        //Split the string into 4 bit numbers with '-'
        for (int i = 4, j = 0; i + j < properString.Length; i += 4, j++)
        {
            properString = properString.Insert(properString.Length - i - j, "-").Trim(new Char[] { '-' }); ;
        }

        //Split the resulting string into the array
        properString.Split('-').CopyTo(arrayBin, 0);


        //Initialize an array to hold the hexadecimal number
        string[] arrayHex = new string[binNum.Length * 4];

        //Convert using a for loop & a switch
        for (int i = 0; i < arrayHex.Length; i++)
        {
            //Binary to hex conversion switch
            switch (arrayBin[i])
            {
                case "0000": arrayHex[i] = "0"; break;
                case "0001": arrayHex[i] = "1"; break;
                case "0010": arrayHex[i] = "2"; break;
                case "0011": arrayHex[i] = "3"; break;
                case "0100": arrayHex[i] = "4"; break;
                case "0101": arrayHex[i] = "5"; break;
                case "0110": arrayHex[i] = "6"; break;
                case "0111": arrayHex[i] = "7"; break;
                case "1000": arrayHex[i] = "8"; break;
                case "1001": arrayHex[i] = "9"; break;
                case "1010": arrayHex[i] = "A"; break;
                case "1011": arrayHex[i] = "B"; break;
                case "1100": arrayHex[i] = "C"; break;
                case "1101": arrayHex[i] = "D"; break;
                case "1110": arrayHex[i] = "E"; break;
                case "1111": arrayHex[i] = "F"; break;
                default: break;
            }
        }

        string finalHex = String.Join("", arrayHex);
        Console.WriteLine("\r\nBinary: {0}\r\n\r\n   HEX: {1}\r\n", binNum, finalHex);
    }
}
//}