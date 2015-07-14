using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//digits 48 to 57
//capital 65 to 90
//lowercase 97 to 122

class Program02
{
    static void Main()
    {
        byte secret = byte.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int encodedValue = 0;
        decimal answer;
        bool cont = true;

        do
        {
            for (int i = 0; i < input.Length; i++)
            {
                //if the symbol is a lower or uppercase letter
                if ((input[i] >= 65 && input[i] <= 90) || (input[i] >= 97 && input[i] <= 122))
                {
                    encodedValue = (input[i] * secret) + 1000;
                }
                //if the symbol is a digit
                else if (input[i] >= 48 && input[i] <= 57)
                {
                    encodedValue = (input[i] + secret + 500);
                }

                //if the symbol is anything else except @
                else if (input[i] != 64)
                {
                    encodedValue = (input[i] - secret);
                }

                //stop in case of @
                else if (input[i] == 64)
                {
                    cont = false;
                }

                if (i % 2 == 0 && cont == true)
                {
                    answer = encodedValue / 100M;
                    Console.WriteLine("{0:0.00}", answer);
                }
                if (i % 2 != 0 && cont == true)
                {
                    answer = encodedValue * 100M;
                    Console.WriteLine(answer);
                }
            }
        } while (cont);
    }
}
