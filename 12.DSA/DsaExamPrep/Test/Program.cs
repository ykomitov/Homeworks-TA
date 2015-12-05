using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringW = "p";
            string stringS = "couterp";

            char[] W = stringW.ToCharArray();
            char[] S = stringS.ToCharArray();

            StringSearcher ss = new StringSearcher(W);
            int ix = ss.Search(S);
            Console.WriteLine("Location of W in S is " + ix);
        }
    }

    public class StringSearcher  // Knuth-Morris-Pratt string search
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

        public int Search(char[] S)
        {
            // look for this.W inside of S
            int m = 0;
            int i = 0;
            while (m + i < S.Length)
            {
                if (this.W[i] == S[m + i])
                {
                    if (i == this.W.Length - 1)
                        return m;
                    ++i;
                }
                else
                {
                    m = m + i - this.T[i];
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
