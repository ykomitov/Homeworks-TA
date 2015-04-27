using System;

class GameOfPage
{
    static void Main()
    {

        string commandEnd = "paypal";
        string commandBuy = "buy";
        string commandWhatIs = "what is";
        int cookieSold = 0;
        double cookiePrice = 1.79;

        int row0 = Convert.ToInt32(Console.ReadLine(), 2);
        int row1 = Convert.ToInt32(Console.ReadLine(), 2);
        int row2 = Convert.ToInt32(Console.ReadLine(), 2);
        int row3 = Convert.ToInt32(Console.ReadLine(), 2);
        int row4 = Convert.ToInt32(Console.ReadLine(), 2);
        int row5 = Convert.ToInt32(Console.ReadLine(), 2);
        int row6 = Convert.ToInt32(Console.ReadLine(), 2);
        int row7 = Convert.ToInt32(Console.ReadLine(), 2);
        int row8 = Convert.ToInt32(Console.ReadLine(), 2);
        int row9 = Convert.ToInt32(Console.ReadLine(), 2);
        int row10 = Convert.ToInt32(Console.ReadLine(), 2);
        int row11 = Convert.ToInt32(Console.ReadLine(), 2);
        int row12 = Convert.ToInt32(Console.ReadLine(), 2);
        int row13 = Convert.ToInt32(Console.ReadLine(), 2);
        int row14 = Convert.ToInt32(Console.ReadLine(), 2);
        int row15 = Convert.ToInt32(Console.ReadLine(), 2);


        while (true)
        {
            string command = Console.ReadLine();
            if (command == commandEnd)
            {
                break;
            }

            int row = int.Parse(Console.ReadLine());
            int col = 15 - int.Parse(Console.ReadLine());

            int upperRow = 0;
            int middleRow = 0;
            int lowerRow = 0;

            switch (row)
            {
                case 0: upperRow = 0; middleRow = row0; lowerRow = row1; break;
                case 1: upperRow = row0; middleRow = row1; lowerRow = row2; break;
                case 2: upperRow = row1; middleRow = row2; lowerRow = row3; break;
                case 3: upperRow = row2; middleRow = row3; lowerRow = row4; break;
                case 4: upperRow = row3; middleRow = row4; lowerRow = row5; break;
                case 5: upperRow = row4; middleRow = row5; lowerRow = row6; break;
                case 6: upperRow = row5; middleRow = row6; lowerRow = row7; break;
                case 7: upperRow = row6; middleRow = row7; lowerRow = row8; break;
                case 8: upperRow = row7; middleRow = row8; lowerRow = row9; break;
                case 9: upperRow = row8; middleRow = row9; lowerRow = row10; break;
                case 10: upperRow = row9; middleRow = row10; lowerRow = row11; break;
                case 11: upperRow = row10; middleRow = row11; lowerRow = row12; break;
                case 12: upperRow = row11; middleRow = row12; lowerRow = row13; break;
                case 13: upperRow = row12; middleRow = row13; lowerRow = row14; break;
                case 14: upperRow = row13; middleRow = row14; lowerRow = row15; break;
                case 15: upperRow = row14; middleRow = row15; lowerRow = row0; break;
            }

            int cookieCenter = 1 << col; //генерира ред с нули и една единица, където ни е колоната
            bool isCookieCrumb = (middleRow & cookieCenter) != 0;
            bool isBrokenCookie =

                isCookieCrumb &&

                //upper row
                ((upperRow & (1 << (col + 1))) != 0) ||
                ((upperRow & (1 << col)) != 0) ||
                ((upperRow & (1 << (col - 1))) != 0) ||

                //middle row
                ((middleRow & (1 << (col + 1))) != 0) ||
                ((middleRow & (1 << (col - 1))) != 0) ||

                //lower row
                ((lowerRow & (1 << (col + 1))) != 0) ||
                ((lowerRow & (1 << col)) != 0) ||
                ((lowerRow & (1 << (col - 1))) != 0);

            bool isWholeCookie =
                                isCookieCrumb &&

                //upper row
                ((upperRow & (1 << (col + 1))) != 0) &&
                ((upperRow & (1 << col)) != 0) &&
                ((upperRow & (1 << (col - 1))) != 0) &&

                //middle row
                ((middleRow & (1 << (col + 1))) != 0) &&
                ((middleRow & (1 << (col - 1))) != 0) &&

                //lower row
                ((lowerRow & (1 << (col + 1))) != 0) &&
                ((lowerRow & (1 << col)) != 0) &&
                ((lowerRow & (1 << (col - 1))) != 0);

            if (command == commandWhatIs)
            {
                if (isWholeCookie)
                {
                    Console.WriteLine("cookie");
                }
                else if (isBrokenCookie)
                {
                    Console.WriteLine("broken cookie");
                }
                else if (isCookieCrumb)
                {
                    Console.WriteLine("cookie crumb");
                }
                else if (command == commandBuy)
                {
                    Console.WriteLine("smile");
                }
            }

            else if (command == commandBuy)
            {
                if (isWholeCookie)
                {
                    ++cookieSold;

                    //clear cookie - remove cookie bits from the rows

                    upperRow ^= 1 << (col - 1);
                    upperRow ^= 1 << (col);
                    upperRow ^= 1 << (col + 1);

                    middleRow ^= 1 << (col - 1);
                    middleRow ^= 1 << (col);
                    middleRow ^= 1 << (col + 1);

                    lowerRow ^= 1 << (col - 1);
                    lowerRow ^= 1 << (col);
                    lowerRow ^= 1 << (col + 1);
                }
                else if (isBrokenCookie)
                {
                    Console.WriteLine("page");
                }
                else if (isCookieCrumb)
                {
                    Console.WriteLine("page");
                }
                else if (command == commandBuy)
                {
                    Console.WriteLine("smile");
                }
                //за да променим редовете

                switch (row)
                {
                    case 0:                  row0 = middleRow; row1 = lowerRow; break;
                    case 1: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 2: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 3: row1 = lowerRow; row2 = middleRow; row3 = lowerRow; break;
                    case 4: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 5: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 6: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 7: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 8: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 9: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 10: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 11: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 12: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 13: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 14: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;
                    case 15: row0 = lowerRow; row1 = middleRow; row2 = lowerRow; break;

                }
            }

        }


        Console.WriteLine(cookieSold * cookiePrice);
    }
}
