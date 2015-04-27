using System;

/*Write a program that exchanges bits `3`, `4` and `5` with bits `24`, `25` and `26` of given 32-bit unsigned integer.

_Examples:_

|      n     |      binary representation of n     |            binary result            |   result   |
|:----------:|:-----------------------------------:|:-----------------------------------:|:----------:|
| 1140867093 | 01000100 00000000 01000000 00010101 | 01000010 00000000 01000000 00100101 | 1107312677 |
| 255406592  | 00001111 00111001 00110010 00000000 | 00001000 00111001 00110010 00111000 | 137966136  |
| 4294901775 | 11111111 11111111 00000000 00001111 | 11111001 11111111 00000000 00111111 | 4194238527 |
| 5351       | 00000000 00000000 00010100 11100111 | 00000100 00000000 00010100 11000111 | 67114183   |
| 2369124121 | 10001101 00110101 11110111 00011001 | 10001011 00110101 11110111 00101001 | 2335569705 |*/

class BitsExchange
{
    static void Main()
    {
        uint n = 2369124121;
        string newNumberString = "";
        int positionBit3InArray = 31 - 3; //calculate array index of bits in which we are interested
        int positionBit4InArray = 31 - 4;
        int positionBit5InArray = 31 - 5;
        int positionBit24InArray = 31 - 24;
        int positionBit25InArray = 31 - 25;
        int positionBit26InArray = 31 - 26;
        char pad = '0';
        int[] newNumberArray = new int[32];
        int[] bitsToExchange = new int[6];

        //Convert int n to a binary string "nBits"
        string nBits = Convert.ToString(n, 2).PadLeft(32, pad);

        Console.WriteLine("orig: " + nBits); //prints original number's bits

        //Fill array "newNumberArray" with the bits of int n, taken out of string "nBits"
        for (int i = 0; i < newNumberArray.Length; i++)
        {
            newNumberArray[i] = Convert.ToInt16(nBits[i].ToString());
        }

        //Fill array bitsToExchange with bits in positions `3`, `4` and `5` and bits `24`, `25` and `26`from input number
        bitsToExchange[0] = newNumberArray[positionBit3InArray];
        bitsToExchange[1] = newNumberArray[positionBit4InArray];
        bitsToExchange[2] = newNumberArray[positionBit5InArray];
        bitsToExchange[3] = newNumberArray[positionBit24InArray];
        bitsToExchange[4] = newNumberArray[positionBit25InArray];
        bitsToExchange[5] = newNumberArray[positionBit26InArray];

        //Exchanges bits `3`, `4` and `5` with bits `24`, `25` and `26`
        newNumberArray[positionBit3InArray] = bitsToExchange[3];
        newNumberArray[positionBit4InArray] = bitsToExchange[4];
        newNumberArray[positionBit5InArray] = bitsToExchange[5];
        newNumberArray[positionBit24InArray] = bitsToExchange[0];
        newNumberArray[positionBit25InArray] = bitsToExchange[1];
        newNumberArray[positionBit26InArray] = bitsToExchange[2];

        //Iterate throuth the array to fill its content in string "newNumberString"
        for (int i = 0; i < newNumberArray.Length; i++)
        {
            newNumberString = newNumberString + newNumberArray[i];
        }

        Console.WriteLine("_new: " + newNumberString); //prints new number with swapped bits

        //Convert newNumberString to integer "newInt"
        uint newInt = Convert.ToUInt32(newNumberString, 2);
        Console.WriteLine("\r\n" + newInt);
    }
}
