using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.Exam_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string two = Console.ReadLine();
            
            var sb = new StringBuilder();
            foreach (var ch in two)
            {
                if (Char.IsDigit(ch))
                {
                    sb.Append(ch - '0');
                }
            }
            string songs = sb.ToString();
            int s = int.Parse(songs);
            string catsongs = "";

            string readString = Console.ReadLine();
            //while (readString != "Mew!")
            //{
            //    catsongs += Console.ReadLine();
            //    readString = Console.ReadLine();
            //}

            Console.WriteLine("No concert!");
        }
    }
}
