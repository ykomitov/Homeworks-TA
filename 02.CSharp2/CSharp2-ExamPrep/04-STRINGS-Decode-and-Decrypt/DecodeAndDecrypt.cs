using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_STRINGS_Decode_and_Decrypt
{
    class DecodeAndDecrypt
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var digits = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(input[i]))
                //if (input[i] >= '0' && input[i] <= '9')
                {
                    //digits.Add(input[i] - '0');
                    digits.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    break;
                }
            }

            digits.Reverse();

            //get the length of the cypher
            StringBuilder builder = new StringBuilder();
            foreach (int digit in digits)
            {
                builder.Append(digit);
            }

            int cypherLength = int.Parse(builder.ToString());
            builder.Clear();

            var encodedMessage = input.Substring(0, input.Length - digits.Count);

            var decodedMessage = Decode(encodedMessage);

            var encryptetMessage = decodedMessage.Substring(0, decodedMessage.Length - cypherLength);

            var cypher = decodedMessage.Substring(decodedMessage.Length - cypherLength);


            Console.WriteLine(Encrypt(encryptetMessage, cypher));

            //Console.WriteLine(Decode("ABBAA6BA") == "ABBAABBBBBBA");
        }

        public static string Decode(string encodedMessage)
        {
            var result = new StringBuilder();
            var count = 0;

            foreach (var ch in encodedMessage)
            {
                if (char.IsDigit(ch))
                {
                    count *= 10;
                    count += int.Parse(ch.ToString());
                }
                else
                {
                    if (count == 0)
                    {
                        result.Append(ch);
                    }
                    else
                    {
                        result.Append(ch, count);
                        count = 0;
                    }
                }
            }
            return result.ToString();
        }

        public static string Encrypt(string message, string cypher)
        {
            var steps = Math.Max(message.Length, cypher.Length);
            var result = new StringBuilder(message);

            for (int i = 0; i < steps; i++)
            {
                var messageIndex = i % message.Length;
                var cypherIndex = i % cypher.Length;

                result[messageIndex] = (char)(((result[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
            }

            return result.ToString();
        }
    }
}
