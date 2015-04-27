/*  Write a method that adds two polynomials. Represent them as arrays of their coefficients.
    Extend the previous program to support also subtraction and multiplication of polynomials.*/

using System;

namespace Problem11AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main()
        {
            decimal[] polynomFirst = new decimal[5] { 5, 2, 4, -7, 3 }; // [2] { 3, 2 }
            decimal[] polynomSecond = new decimal[8] { 2, 0, -2, 4, 3, 2, 1, 6 }; // [3] { 9, -6, 4 }

            if (polynomSecond.Length > polynomFirst.Length)
            {
                Console.Write(new string(' ', 7));
            }
            Console.WriteLine(string.Join(" ", polynomFirst));
            Console.WriteLine(string.Join(" ", polynomSecond));
            Console.WriteLine();
            Console.WriteLine("\r\nAdding polynomials");
            Console.WriteLine(string.Join(" ", AddPolynomials(polynomFirst, polynomSecond)));
            Console.WriteLine("\r\nSubtraction");
            Console.WriteLine(string.Join(" ", Subtraction(polynomFirst, polynomSecond)));
            Console.WriteLine("\r\nMultiplication");
            Console.WriteLine(string.Join(" ", Multiplication(polynomFirst, polynomSecond)));
            Console.WriteLine();
        }
        static decimal[] AddPolynomials(decimal[] polynomOne, decimal[] polynomTwo)
        {
            int polynomMinLenght = Math.Min(polynomOne.Length, polynomTwo.Length);
            decimal[] rezult = new decimal[Math.Max(polynomOne.Length, polynomTwo.Length)];
            Array.Reverse(polynomOne);
            Array.Reverse(polynomTwo);
            for (int i = 0; i < polynomMinLenght; i++)
            {
                rezult[i] = polynomOne[i] + polynomTwo[i];
            }
            if (polynomOne.Length > polynomTwo.Length)
            {
                for (int i = polynomTwo.Length; i < polynomOne.Length; i++)
                {
                    rezult[i] = polynomOne[i];
                }
            }
            if (polynomOne.Length < polynomTwo.Length)
            {
                for (int i = polynomOne.Length; i < polynomTwo.Length; i++)
                {
                    rezult[i] = polynomTwo[i];
                }
            }
            Array.Reverse(polynomOne);
            Array.Reverse(polynomTwo);
            Array.Reverse(rezult);
            return rezult;
        }
        static decimal[] Subtraction(decimal[] polynomOneSub, decimal[] polynomTwoSub)
        {
            int polynomMinLenght = Math.Min(polynomOneSub.Length, polynomTwoSub.Length);
            decimal[] resultSub = new decimal[Math.Max(polynomOneSub.Length, polynomTwoSub.Length)];
            Array.Reverse(polynomOneSub);
            Array.Reverse(polynomTwoSub);
            for (int i = 0; i < polynomMinLenght; i++)
            {
                resultSub[i] = polynomOneSub[i] - polynomTwoSub[i];
            }
            if (polynomOneSub.Length > polynomTwoSub.Length)
            {
                for (int i = polynomTwoSub.Length; i < polynomOneSub.Length; i++)
                {
                    resultSub[i] = polynomOneSub[i];
                }
            }
            if (polynomOneSub.Length < polynomTwoSub.Length)
            {
                for (int i = polynomOneSub.Length; i < polynomTwoSub.Length; i++)
                {
                    resultSub[i] = polynomTwoSub[i];
                }
            }
            Array.Reverse(polynomOneSub);
            Array.Reverse(polynomTwoSub);
            Array.Reverse(resultSub);
            return resultSub;
        }
        static decimal[] Multiplication(decimal[] polynomOneMul, decimal[] polynomTwoMul)
        {
            decimal[] resultMul = new decimal[polynomOneMul.Length + polynomTwoMul.Length - 1];
            for (int i = polynomOneMul.Length - 1; i >= 0; i--)
            {
                for (int j = polynomTwoMul.Length - 1; j >= 0; j--)
                {
                    resultMul[i + j] += (polynomOneMul[i] * polynomTwoMul[j]);
                }
            }
            return resultMul;
        }
    }
}

