namespace _001.Exam_Problem1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Problem1
    {
        internal static void Main()
        {
            string input = Console.ReadLine();

            var inputStringAsArray = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var finalResultArray = new List<string>();

            foreach (var word in inputStringAsArray)
            {
                string inputTo21Base = ConvertTo21Base(word);
                long inputToDecimal = ArbitraryToDecimalSystem(inputTo21Base.ToString(), 21);
                string inputTo26Base = DecimalToArbitrarySystem(inputToDecimal, 26).ToLower();
                string inputTranslatedInEnglish = ConvertToEnglish(inputTo26Base);

                finalResultArray.Add(inputTranslatedInEnglish);
            }

            string finalResult = string.Join(" ", finalResultArray.ToArray());
            Console.WriteLine(finalResult);
        }

        internal static string ConvertTo21Base(string input)
        {
            var result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i].ToString())
                {
                    case "a": result.Append("0"); break;
                    case "b": result.Append("1"); break;
                    case "c": result.Append("2"); break;
                    case "d": result.Append("3"); break;
                    case "e": result.Append("4"); break;
                    case "f": result.Append("5"); break;
                    case "g": result.Append("6"); break;
                    case "h": result.Append("7"); break;
                    case "i": result.Append("8"); break;
                    case "j": result.Append("9"); break;
                    case "k": result.Append("a"); break;
                    case "l": result.Append("b"); break;
                    case "m": result.Append("c"); break;
                    case "n": result.Append("d"); break;
                    case "o": result.Append("e"); break;
                    case "p": result.Append("f"); break;
                    case "q": result.Append("g"); break;
                    case "r": result.Append("h"); break;
                    case "s": result.Append("i"); break;
                    case "t": result.Append("j"); break;
                    case "u": result.Append("k"); break;
                    default: break;
                }
            }

            return result.ToString();
        }

        internal static long ArbitraryToDecimalSystem(string number, int radix)
        {
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
            {
                throw new ArgumentException("The radix must be >= 2 and <= " +
                              Digits.Length.ToString());
            }

            if (string.IsNullOrEmpty(number))
            {
                return 0;
            }

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
                {
                    throw new ArgumentException(
                        "Invalid character in the arbitrary numeral system number",
                        "number");
                }

                result += digit * multiplier;
                multiplier *= radix;
            }

            return result;
        }

        internal static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
            {
                throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());
            }

            if (decimalNumber == 0)
            {
                return "0";
            }

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new string(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }

        internal static string ConvertToEnglish(string input)
        {
            var result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i].ToString())
                {
                    case "0": result.Append("a"); break;
                    case "1": result.Append("b"); break;
                    case "2": result.Append("c"); break;
                    case "3": result.Append("d"); break;
                    case "4": result.Append("e"); break;
                    case "5": result.Append("f"); break;
                    case "6": result.Append("g"); break;
                    case "7": result.Append("h"); break;
                    case "8": result.Append("i"); break;
                    case "9": result.Append("j"); break;
                    case "a": result.Append("k"); break;
                    case "b": result.Append("l"); break;
                    case "c": result.Append("m"); break;
                    case "d": result.Append("n"); break;
                    case "e": result.Append("o"); break;
                    case "f": result.Append("p"); break;
                    case "g": result.Append("q"); break;
                    case "h": result.Append("r"); break;
                    case "i": result.Append("s"); break;
                    case "j": result.Append("t"); break;
                    case "k": result.Append("u"); break;
                    case "l": result.Append("v"); break;
                    case "m": result.Append("w"); break;
                    case "n": result.Append("x"); break;
                    case "o": result.Append("y"); break;
                    case "p": result.Append("z"); break;
                    default: break;
                }
            }

            return result.ToString();
        }
    }
}
