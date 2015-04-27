using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Program04
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = (2 * n) + 1;
        int xHorizontal = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < width; i++)
        {
            string middle = new string
                            ('#', width);
            Console.WriteLine(middle);
        }

        ////middle of the X
        //string middle = new string
        //                            ('.', (width-(xHorizontal+2))/2)+
        //                            "X"+
        //                            new string('#', xHorizontal)+
        //                            "X"+
        //                            new string('.', (width-(xHorizontal+2))/2);
        //Console.WriteLine(middle);

        ////lower part of the X
        //        string lower = new string
        //                            ('.', (width-((xHorizontal+2))/2)-1)+
        //                            "/"+
        //                            new string('#', xHorizontal)+
        //                            "X"+
        //                            new string('.', (width-(xHorizontal+2))/2);
    }
}
