using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _001.Exam_Problem1
{
    class Problem1
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var tempList1 = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var tempList2 = new List<string>();

            foreach (var word in tempList1)
            {
                string input21 = ConvertTo21(word);
                long input10 = ArbitraryToDecimalSystem(input21.ToString(), 21);
                string input26 = DecimalToArbitrarySystem(input10, 26).ToLower();
                string cat = ConvertToCat(input26);
                tempList2.Add(cat);
            }

            string finalResult = string.Join(" ", tempList2.ToArray());
            Console.WriteLine(finalResult);

        }

        static string ConvertTo21(string input)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i].ToString())
                {
                    case "a": sb.Append("0"); break;
                    case "b": sb.Append("1"); break;
                    case "c": sb.Append("2"); break;
                    case "d": sb.Append("3"); break;
                    case "e": sb.Append("4"); break;
                    case "f": sb.Append("5"); break;
                    case "g": sb.Append("6"); break;
                    case "h": sb.Append("7"); break;
                    case "i": sb.Append("8"); break;
                    case "j": sb.Append("9"); break;
                    case "k": sb.Append("a"); break;
                    case "l": sb.Append("b"); break;
                    case "m": sb.Append("c"); break;
                    case "n": sb.Append("d"); break;
                    case "o": sb.Append("e"); break;
                    case "p": sb.Append("f"); break;
                    case "q": sb.Append("g"); break;
                    case "r": sb.Append("h"); break;
                    case "s": sb.Append("i"); break;
                    case "t": sb.Append("j"); break;
                    case "u": sb.Append("k"); break;
                    default: break;
                }
            }
            return sb.ToString();
        }

        public static long ArbitraryToDecimalSystem(string number, int radix)
        {
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //"0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            //"0123456789abcdefghijklmnopqrstuvwxyz"
            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " +
                    Digits.Length.ToString());

            if (String.IsNullOrEmpty(number))
                return 0;

            // Make sure the arbitrary numeral system number is in upper case
            number = number.ToUpperInvariant();

            long result = 0;
            long multiplier = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                char c = number[i];
                if (i == 0 && c == '-')
                {
                    // This is the negative sign symbol
                    result = -result;
                    break;
                }

                int digit = Digits.IndexOf(c);
                if (digit == -1)
                    throw new ArgumentException(
                        "Invalid character in the arbitrary numeral system number",
                        "number");

                result += digit * multiplier;
                multiplier *= radix;
            }

            return result;
        }

        public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }

        static string ConvertToCat(string input)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i].ToString())
                {
                    case "0": sb.Append("a"); break;
                    case "1": sb.Append("b"); break;
                    case "2": sb.Append("c"); break;
                    case "3": sb.Append("d"); break;
                    case "4": sb.Append("e"); break;
                    case "5": sb.Append("f"); break;
                    case "6": sb.Append("g"); break;
                    case "7": sb.Append("h"); break;
                    case "8": sb.Append("i"); break;
                    case "9": sb.Append("j"); break;
                    case "a": sb.Append("k"); break;
                    case "b": sb.Append("l"); break;
                    case "c": sb.Append("m"); break;
                    case "d": sb.Append("n"); break;
                    case "e": sb.Append("o"); break;
                    case "f": sb.Append("p"); break;
                    case "g": sb.Append("q"); break;
                    case "h": sb.Append("r"); break;
                    case "i": sb.Append("s"); break;
                    case "j": sb.Append("t"); break;
                    case "k": sb.Append("u"); break;
                    case "l": sb.Append("v"); break;
                    case "m": sb.Append("w"); break;
                    case "n": sb.Append("x"); break;
                    case "o": sb.Append("y"); break;
                    case "p": sb.Append("z"); break;
                    default: break;
                }
            }
            return sb.ToString();
        }
    }
}
