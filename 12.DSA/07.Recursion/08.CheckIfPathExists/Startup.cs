/*Modify the above program to check whether a path exists between two cells without finding all possible paths.

    Test it over an empty 100 x 100 matrix.
*/

namespace _08.CheckIfPathExists
{
    using System;

    public class Startup
    {
        private static bool pathFound = false;

        public static void Main()
        {
            ////var maze = new char[,]
            ////                       {
            ////                         { ' ', 'X', ' ', ' ', ' ', ' ' },
            ////                         { ' ', 'X', ' ', 'X', 'X', ' ' },
            ////                         { ' ', 'X', ' ', 'X', 'X', ' ' },
            ////                         { ' ', ' ', ' ', ' ', ' ', ' ' },
            ////                         { ' ', 'X', 'X', 'X', 'X', ' ' },
            ////                         { ' ', ' ', ' ', ' ', ' ', ' ' }
            ////                       };

            var maze = new char[100, 100];

            CheckIfPathExists(0, 0, 54, 36, maze);
        }

        public static void CheckIfPathExists(int startRow, int startCol, int targetRow, int targetCol, char[,] maze)
        {
            if (pathFound)
            {
                return;
            }

            if (IsValidMove(startRow, startCol, maze))
            {
                maze[targetRow, targetCol] = 'E';

                if (maze[startRow, startCol] == 'E')
                {
                    ////PrintMaze(maze);
                    Console.WriteLine("Path found!");
                    pathFound = true;
                    return;
                }

                maze[startRow, startCol] = '+';

                // up row-1 col
                CheckIfPathExists(startRow - 1, startCol, targetRow, targetCol, maze);

                // right row col+1
                CheckIfPathExists(startRow, startCol + 1, targetRow, targetCol, maze);

                // down row+1 col
                CheckIfPathExists(startRow + 1, startCol, targetRow, targetCol, maze);

                // left row col-1
                CheckIfPathExists(startRow, startCol - 1, targetRow, targetCol, maze);
            }
        }

        public static void PrintMaze(char[,] maze)
        {
            Console.WriteLine(" " + new string('=', (maze.GetLength(0) * 2) - 1));
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        Console.Write("|");
                    }

                    if (col == maze.GetLength(1) - 1)
                    {
                        Console.WriteLine(maze[row, col] + "|");
                    }
                    else
                    {
                        Console.Write(maze[row, col] + " ");
                    }
                }
            }

            Console.WriteLine(" " + new string('=', (maze.GetLength(0) * 2) - 1));
            Console.WriteLine();
        }

        private static bool IsValidMove(int targetRow, int targetCol, char[,] maze)
        {
            if (targetRow >= maze.GetLength(0) || targetRow < 0 ||
                targetCol >= maze.GetLength(1) || targetCol < 0)
            {
                return false;
            }
            else if (maze[targetRow, targetCol] == 'X')
            {
                return false;
            }
            else if (maze[targetRow, targetCol] == '+')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
