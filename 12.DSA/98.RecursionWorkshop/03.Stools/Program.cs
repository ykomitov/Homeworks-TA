namespace _03.Stools
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Stool
    {
        public Stool(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }
    }

    public class Program
    {
        static Stool[] stools;
        static int n;
        static int[,,] memo;

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());
            stools = new Stool[n];
            //memo = new int[1 << n, n, 3];
            memo = new int[1 << n, 16, 4];

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                stools[i] = new Stool(
                    int.Parse(line[0]),
                    int.Parse(line[1]),
                    int.Parse(line[2]));
            }

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result = Math.Max(result, MaxHeight((1 << n) - 1, i, j));
                }
            }

            Console.WriteLine(result);
        }

        static int MaxHeight(int used, int top, int side)
        {
            if (used == 1 << top)
            {
                if (side == 0) // x = 0, y = 1, z = 2
                {
                    return stools[top].X;
                }
                if (side == 1)
                {
                    return stools[top].Y;
                }
                return stools[top].Z;
            }

            if (memo[used, top, side] != 0)
            {
                return memo[used, top, side];
            }

            int fromStoops = used ^ (1 << top);

            int SideX = (side == 0) ? stools[top].Y : stools[top].X;
            int SideY = (side == 2) ? stools[top].Y : stools[top].Z;
            int SideH = stools[top].X + stools[top].Y + stools[top].Z - SideX - SideY;
            /*
            0 - Y Z
            1 - X Z
            2 - X Y
            */

            int result = SideH;
            for (int i = 0; i < n; i++)
            {
                if (((fromStoops >> i) & 1) == 1)
                {
                    // side of stools[i] == 0
                    if ((stools[i].Y >= SideX && stools[i].Z >= SideY) ||
                        (stools[i].Y >= SideY && stools[i].Z >= SideX))
                    {
                        result = Math.Max(result, MaxHeight(fromStoops, i, 0) + SideH);
                    }

                    if (stools[i].X == stools[i].Y && stools[i].X == stools[i].Z)
                    {
                        continue;
                    }

                    // side of stools[i] == 1
                    if ((stools[i].X >= SideX && stools[i].Z >= SideY) ||
                        (stools[i].X >= SideY && stools[i].Z >= SideX))
                    {
                        result = Math.Max(result, MaxHeight(fromStoops, i, 1) + SideH);
                    }

                    // side of stools[i] == 2
                    if ((stools[i].X >= SideX && stools[i].Y >= SideY) ||
                        (stools[i].X >= SideY && stools[i].Y >= SideX))
                    {
                        result = Math.Max(result, MaxHeight(fromStoops, i, 2) + SideH);
                    }

                    //          fromStoops = fromStoops >> 1;
                }
            }


            memo[used, top, side] = result;
            return result;
        }
    }
}
