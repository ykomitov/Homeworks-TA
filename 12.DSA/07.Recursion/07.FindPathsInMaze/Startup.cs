/*We are given a matrix of passable and non-passable cells.

    Write a recursive program for finding all paths between two cells in the matrix.
*/

namespace _07.FindPathsInMaze
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var maze = new char[,]
                                   {
                                     { ' ', 'X', ' ', ' ', ' ', ' ' },
                                     { ' ', 'X', ' ', 'X', 'X', ' ' },
                                     { ' ', 'X', ' ', 'X', 'X', ' ' },
                                     { ' ', ' ', ' ', ' ', ' ', ' ' },
                                     { ' ', 'X', 'X', 'X', 'X', ' ' },
                                     { ' ', ' ', ' ', ' ', ' ', 'E' }
                                   };

            PrintAllPathsInMaze(0, 0, maze);
        }

        public static void PrintAllPathsInMaze(int startRow, int startCol, char[,] maze)
        {
            if (IsValidMove(startRow, startCol, maze))
            {
                if (maze[startRow, startCol] == 'E')
                {
                    PrintMaze(maze);
                    return;
                }

                maze[startRow, startCol] = '+';

                // up row-1 col
                PrintAllPathsInMaze(startRow - 1, startCol, maze);

                // right row col+1
                PrintAllPathsInMaze(startRow, startCol + 1, maze);

                // down row+1 col
                PrintAllPathsInMaze(startRow + 1, startCol, maze);

                // left row col-1
                PrintAllPathsInMaze(startRow, startCol - 1, maze);
                maze[startRow, startCol] = ' ';
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
