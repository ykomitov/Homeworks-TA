/*Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.*/

namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int lenght)
        {
            string input = sb.ToString();
            sb.Clear();
            sb.Append(input.Substring(index, lenght));
            return sb;
        }

        static void Main()
        {
            string testString = "The quick brown fox jumped over the lazy dog.";

            Console.WriteLine("Original string: {0}", testString);
            //.Substring method for strings
            Console.WriteLine("String:          {0}", testString.Substring(0, 19));

            //.Substring extension method for StringBuilder
            StringBuilder sbTest = new StringBuilder("The quick brown fox jumped over the lazy dog.");
            Console.WriteLine("StringBuilder:   {0}", sbTest.Substring(0, 19).ToString());
        }
    }
}
