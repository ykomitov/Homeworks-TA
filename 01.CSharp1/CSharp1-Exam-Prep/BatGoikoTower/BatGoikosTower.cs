using System;

class BatGoikosTower
{
    static void Main()
    {
        //(n-1*'.'+'/'+0*'-'+'\'+(n-1)*".")
        int n = int.Parse(Console.ReadLine());
        var middleChar = '.';
        int update = 2;
        int rowToHaveDash = 2;


        for (int i = 1; i <= n; i++)
        {
            if (i == rowToHaveDash)
            {
                middleChar = '-';
                rowToHaveDash += update;
                ++update;
            }
            string row =
                new string('.', n - i) +
                "/" +
                new string(middleChar, 2 * i - 2) +
                "\\" +
                new string('.', n - i);
            Console.WriteLine(row);

            //2n = n-1 + 1  + 1 + n - i + x
            //2n = 2*n - 2*i - 2*i +2 + x
            //n = n-i +1 +x/2
            //x/2 = i-1
            //x = 2*i - 2
        }

    }
}
