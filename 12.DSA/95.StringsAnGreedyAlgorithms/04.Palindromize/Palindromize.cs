namespace _04.Palindromize
{
    using System;

    public class Palindromize
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            string lettersToAdd = string.Empty;
            var palindromizeIndex = 0;

            if (IsPalindrome(input))
            {
                Console.WriteLine(input);
                return;
            }

            string result = "sa";
            while (!IsPalindrome(result))
            {
                lettersToAdd += input[palindromizeIndex];
                char[] charArray = lettersToAdd.ToCharArray();
                Array.Reverse(charArray);
                var reversedLettersToAdd = new string(charArray);
                result = input + reversedLettersToAdd;
                palindromizeIndex++;
            }

            Console.WriteLine(result);
        }

        public static bool IsPalindrome(string input)
        {
            bool isPalindrome = true;

            for (int i = 0, j = input.Length - 1; i < input.Length / 2; i++, j--)
            {
                if (input[i] != input[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
