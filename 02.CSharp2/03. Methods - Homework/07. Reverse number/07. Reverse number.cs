/*Write a method that reverses the digits of given decimal number.
    input 	output
    256 	652
    123.45 	54.321*/

using System;
using System.Text;

namespace ReverseDigits
{
    public class ReverseAllDigits
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter a decimal number: ");
                decimal num = decimal.Parse(Console.ReadLine());

                Console.WriteLine("The number {0} can be reversed to {1}\n", num, ReverseDigits(num));
            }

        }

        public static decimal ReverseDigits(decimal num)
        {
            StringBuilder sb = new StringBuilder();
            string numAsString = num.ToString();

            if (numAsString.LastIndexOf('.') >= 0)
            {
                string integerPart = numAsString.Substring(0, numAsString.LastIndexOf('.'));
                string mantissa = numAsString.Substring(numAsString.LastIndexOf('.') + 1);

                //Generate the reversed integer part
                string reversedIntPart = "";
                for (int i = integerPart.Length - 1; i >= 0; i--)
                {
                    sb.Append(integerPart[i]);
                }
                reversedIntPart = sb.ToString();
                sb.Clear(); //Clear the content of the StringBuilder

                //Generate the reversed mantissa
                string reversedMantissa = "";
                for (int i = mantissa.Length - 1; i >= 0; i--)
                {
                    sb.Append(mantissa[i]);
                }
                reversedMantissa = sb.ToString();

                //Generate the reversed decimal integerPart
                decimal finalReversedNum = decimal.Parse(reversedMantissa + "." + reversedIntPart);
                return finalReversedNum;
            }
            else
            {
                //Generate the reversed decimal (case where there is no mantissa)
                for (int i = numAsString.Length - 1; i >= 0; i--)
                {
                    sb.Append(numAsString[i]);
                }
                decimal finalReversedNum = decimal.Parse(sb.ToString());
                return finalReversedNum;
            }
        }
    }
}