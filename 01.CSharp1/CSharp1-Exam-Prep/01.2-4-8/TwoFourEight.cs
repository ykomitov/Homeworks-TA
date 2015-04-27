using System;
using System.Numerics;

/*You are given three numbers A, B, C, where B is actually the secret code symbol.
•	If the code is 2 – find the remainder after A is divided by C. Example: A = 5, C = 3, A % C = 2.
•	If the code is 4 – find the sum of A and C. Example: A = 5, C = 3, A + C = 8.
•	If the code is 8 – find the product of A and C. Example: A = 5, C = 3, A * C = 15.
After you find the result R from the code transformation, if R can be divided by 4 with remainder 0, find R divided by 4. Otherwise find the remainder after R is divided by 4. 
For example, if R is 16, it can be divided by 4 with no remainder, so the answer is 4. If R is 9, it cannot be divided by 4, so the answer is 1.
Input
The input data should be read from the console.
On the first input line you will receive the positive integer A.
On the second input line you will receive the positive integer B.
On the third input line you will receive the positive integer C.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
If R can be divided by 4 with no remainder, on the first output line you should print R divided by 4.
Otherwise, on the first output line you should print the remainder after R is divided by 4.
On the second output line, you should print R.
Constraints
•	A, B and C will be positive integers between 1 and 999 999, inclusive.
•	Allowed working time for your program: 0.10 seconds. Allowed memory: 16 MB.*/

class TwoFourEight
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine()); //<------------- secret code symbol ------------------- 
        int c = int.Parse(Console.ReadLine());
        BigInteger remainderAC = a % c;
        BigInteger sumAC = a + c;
        BigInteger productAC = (BigInteger)a * c;
        BigInteger resultFromTransformation = 0;
        BigInteger finalResult;

       

        //Find result from transformation

        if (b == 2)
        {
            resultFromTransformation = remainderAC;
        }
        else if (b == 4)
        {
            resultFromTransformation = sumAC;
        }
        else if (b == 8)
        {
            resultFromTransformation = productAC;
        }

        //Find the final result
        if (resultFromTransformation % 4 == 0)
        {
            finalResult = resultFromTransformation / 4;
            Console.WriteLine(finalResult);
            Console.WriteLine(resultFromTransformation);
        }
        else 
        {
            finalResult = resultFromTransformation % 4;
            Console.WriteLine(finalResult);
            Console.WriteLine(resultFromTransformation);
        }

    }
}
