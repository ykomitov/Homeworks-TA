using System;

/*	We are given an integer number `n`, a bit value `v` (v=0 or 1) and a position `p`.
	Write a sequence of operators (a few lines of C# code) that modifies `n` to hold the value `v` at the position `p` from the binary representation of `n` while preserving all other bits in `n`.

_Examples:_

|   n   | binary representation of n |  p  | v |   binary result   | result |
|:-----:|:--------------------------:|:---:|:-:|:-----------------:|--------|
| 5     | 00000000 00000101          | 2   | 0 | 00000000 00000001 | 1      |
| 0     | 00000000 00000000          | 9   | 1 | 00000010 00000000 | 512    |
| 15    | 00000000 00001111          | 1   | 1 | 00000000 00001111 | 15     |
| 5343  | 00010100 11011111          | 7   | 0 | 00010100 01011111 | 5215   |
| 62241 | 11110011 00100001          | 11  | 0 | 11110011 00100001 | 62241  |*/

class ModifyBit
{
    static void Main()
    {
        int n = 5;
        int p = 2;
        int v = 0;
        string newNumberString = "";
        int positionInArray = 31 - p;
        char pad = '0';
        int[] newNumberArray = new int[32];
        
        //Convert int n to a binary string "nBits"
        string nBits = Convert.ToString(n, 2).PadLeft(32, pad);

        //Fill array "newNumberArray" with the bits of int n, taken out of string "nBits"
        for (int i = 0; i < newNumberArray.Length; i++)
        {
            newNumberArray[i] = Convert.ToInt16(nBits[i].ToString());
        }

        //Modify the bit at position p with the value of v
        newNumberArray[positionInArray] = v;

        //Iterate throuth the array to fill its content in string "newNumberString"
        for (int i = 0; i < newNumberArray.Length; i++)
        {
            Console.Write(newNumberArray[i]);
            newNumberString = newNumberString + newNumberArray[i]; 
        }

        //Convert newNumberString to integer "newInt"
        int newInt = Convert.ToInt32(newNumberString, 2);
        Console.WriteLine("\r\n"+newInt);
    }
}
