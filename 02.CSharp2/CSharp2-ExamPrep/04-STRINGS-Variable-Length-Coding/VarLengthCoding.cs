using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_STRINGS_Variable_Length_Coding
{
    class VarLengthCoding
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var sequence = new List<int>();

            //split the string and create an array of strings
            var numbersAsString = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            //convert strings to integers and put in the list
            foreach (var number in numbersAsString)
            {
                sequence.Add(int.Parse(number));
            }

            //create the dictionary & fill it with the chars
            int charArrLen = int.Parse(Console.ReadLine());
            var dictionary = new char[charArrLen + 1];

            for (int i = 0; i < charArrLen; i++)
            {
                string charString = Console.ReadLine();
                char inputChar = charString[0];
                int index = int.Parse(charString.Substring(1));
                dictionary[index] = inputChar;
            }

            //convert integers to binary string, padded with zeros, add to stringbuilder
            var builder = new StringBuilder();
            foreach (var item in sequence)
            {
                string intAsString = Convert.ToString(item, 2).PadLeft(8, '0');
                builder.Append(intAsString);
            }
            //append additional zero to the end
            builder.Append("0");

            string decodedSequence = builder.ToString();

            builder.Clear();

            int countOnes = 0;
            foreach (var item in decodedSequence)
            {
                if (item == '1')
                {
                    countOnes++;
                }
                else
                {
                    builder.Append(dictionary[countOnes]);
                    countOnes = 0;
                }
            }

            string finalResult = builder.ToString();
            Console.WriteLine(finalResult);
        }
    }
}
