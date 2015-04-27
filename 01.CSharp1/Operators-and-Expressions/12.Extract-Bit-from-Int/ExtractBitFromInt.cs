using System;

/*	Write an expression that extracts from given integer `n` the value of given bit at index `p`.

_Examples:_

|   n   | binary representation |  p  | bit @ p |
|:-----:|:---------------------:|:---:|:-------:|
| 5     | 00000000 00000101     | 2   | 1       |
| 0     | 00000000 00000000     | 9   | 0       |
| 15    | 00000000 00001111     | 1   | 1       |
| 5343  | 00010100 11011111     | 7   | 1       |
| 62241 | 11110011 00100001     | 11  | 0       |*/

class ExtractBitFromInt
{
    static void Main()
    {
        int n = 5343;
        int p = 10;

        //Решение с битови операции

        int t = 1;
        int shiftedN = n >> p;
        int extractedBit = shiftedN & t;
        Console.WriteLine(extractedBit);

        //Решение с масиви

        //int positionInMassive = 31 - p;
        //char pad = '0';
        //string nBits = Convert.ToString(n, 2).PadLeft(32, pad);
        //Console.WriteLine(nBits[positionInMassive]);
    }
}
