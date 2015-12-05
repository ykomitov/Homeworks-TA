namespace ActualExam_06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program6
    {
        public static void Main()
        {
            //string word = "xx";
            //string text = "xxx";

            var word = Console.ReadLine();
            var text = Console.ReadLine();

            char[] S = text.ToCharArray();

            var prefix = "";
            BigInteger result = 0;
            for (int i = 0; i < word.Length; i++)
            {
                prefix += word[i];

                var suffix = "";

                for (int j = i; j < word.Length - 1; j++)
                {
                    suffix += word[j + 1];
                }

                char[] prefixCharArr = prefix.ToCharArray();
                char[] suffixCharArr = suffix.ToCharArray();


                StringSearcher prefixSearcher = new StringSearcher(prefixCharArr);

                int prefixIndex = 0;
                BigInteger prefixCount = 0;
                do
                {
                    prefixIndex = prefixSearcher.Search(S, prefixIndex);

                    if (prefixIndex != -1)
                    {
                        prefixCount++;
                        //prefixIndex += prefix.Length;
                        prefixIndex++;
                    }
                } while (prefixIndex != -1);

                int suffixIndex = 0;
                BigInteger suffixCount = 0;
                if (suffix != "")
                {
                    StringSearcher suffixSearcher = new StringSearcher(suffixCharArr);
                    do
                    {
                        suffixIndex = suffixSearcher.Search(S, suffixIndex);

                        if (suffixIndex != -1)
                        {
                            suffixCount++;
                            //suffixIndex += suffix.Length;
                            suffixIndex++;
                        }
                    } while (suffixIndex != -1);
                }
                else
                {
                    suffixCount = 1;
                }


                result += prefixCount * suffixCount;
            }

            Console.WriteLine(result);
        }

        // Knuth-Morris-Pratt string search, copied and modified from
        // https://jamesmccaffrey.wordpress.com/2012/08/18/the-knuth-morris-pratt-string-search-algorithm-in-c/
        public class StringSearcher
        {
            private char[] W;  // the (small) pattern to search for
            private int[] T;   // lets the search function to skip ahead

            public StringSearcher(char[] W)
            {
                this.W = new char[W.Length];
                Array.Copy(W, this.W, W.Length);
                this.T = BuildTable(W);           // use a helper to build T
            }

            private int[] BuildTable(char[] W)
            {
                int[] result = new int[W.Length];
                int pos = 2;
                int cnd = 0;
                result[0] = -1;

                if (!(W.Length < 2))
                {
                    result[1] = 0;
                }

                while (pos < W.Length)
                {
                    if (W[pos - 1] == W[cnd])
                    {
                        ++cnd; result[pos] = cnd; ++pos;
                    }
                    else if (cnd > 0)
                        cnd = result[cnd];
                    else
                    {
                        result[pos] = 0; ++pos;
                    }
                }
                return result;
            }

            public int Search(char[] S, int start)
            {
                // look for this.W inside of S
                //int start = 0;
                int i = 0;
                while (start + i < S.Length)
                {
                    if (this.W[i] == S[start + i])
                    {
                        if (i == this.W.Length - 1)
                            return start;
                        ++i;
                    }
                    else
                    {
                        start = start + i - this.T[i];
                        if (this.T[i] > -1)
                            i = this.T[i];
                        else
                            i = 0;
                    }
                }
                return -1;  // not found
            }
        }
    }
}