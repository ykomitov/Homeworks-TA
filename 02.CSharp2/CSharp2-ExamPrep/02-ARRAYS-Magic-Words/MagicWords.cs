using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ARRAYS_Magic_Words
{
    class MagicWords
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            string temp = String.Empty;
            for (int i = 0; i < n; i++)
            {
                temp = list[i];
                int newPosition = list[i].Length % (n + 1);
                list[i] = int.MinValue.ToString();
                list.Insert(newPosition, temp);
                list.Remove(int.MinValue.ToString());
            }

            int longestWord = 0;
            foreach (var word in list)
            {
                longestWord = Math.Max(word.Length, longestWord);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < longestWord; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (list[j].Length >i)
                    {
                        sb.Append(list[j].Substring(i, 1));
                    }
                }
            }
            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
