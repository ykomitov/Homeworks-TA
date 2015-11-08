// Write a recursive program to find the largest connected area of adjacent empty cells in a matrix.

namespace _09.LargestAreaOfAdjacentCells
{
    using System;

    public class Startup
    {
        private const char X = 'X';     // Wall
        private const char O = ' ';     // Empty
        private const char F = '+';     // Open

        private static int tempCount = 0;
        private static int bestCount = 0;
        private static int tempRowStart;
        private static int tempColStart;
        private static int bestRowStart;
        private static int bestColStart;

        public static void Main()
        {
            var maze = new char[,]
                                   {
                                     { O, X, O, O, O, O },
                                     { O, X, O, X, X, O },
                                     { O, X, O, X, X, O },
                                     { X, O, O, O, O, O },
                                     { O, X, X, X, X, X },
                                     { O, O, O, O, O, O }
                                   };

            ////var maze = new char[,]
            ////           {
            ////                         { O, X, O, X, O, O },
            ////                         { O, X, O, X, X, O },
            ////                         { O, X, X, X, X, X },
            ////                         { X, O, O, X, O, O },
            ////                         { O, X, X, X, X, X },
            ////                         { O, O, O, X, O, O }
            ////           };

            FindLargestAreaOfAdjacentEmptyCells(maze);
            Console.WriteLine("Largest connected area of adjacent empty cells: {0}", bestCount);
            RevertMazeToOriginal(maze);
            CountAdjacentEmptyCells(bestRowStart, bestColStart, maze);
            PrintMaze(maze);
        }

        public static void CountAdjacentEmptyCells(int startRow, int startCol, char[,] maze)
        {
            if (!IsValidMove(startRow, startCol, maze))
            {
                return;
            }

            if (IsValidMove(startRow, startCol, maze))
            {
                if (maze[startRow, startCol] == O)
                {
                    maze[startRow, startCol] = F;
                    tempCount++;
                }

                // up row-1 col
                CountAdjacentEmptyCells(startRow - 1, startCol, maze);

                // right row col+1
                CountAdjacentEmptyCells(startRow, startCol + 1, maze);

                // down row+1 col
                CountAdjacentEmptyCells(startRow + 1, startCol, maze);

                // left row col-1
                CountAdjacentEmptyCells(startRow, startCol - 1, maze);
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

        public static void FindLargestAreaOfAdjacentEmptyCells(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    tempCount = 0;
                    tempRowStart = i;
                    tempColStart = j;

                    CountAdjacentEmptyCells(i, j, maze);

                    if (tempCount > bestCount)
                    {
                        bestCount = tempCount;
                        bestRowStart = tempRowStart;
                        bestColStart = tempColStart;
                    }
                }
            }
        }

        private static void RevertMazeToOriginal(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (maze[i, j] == F)
                    {
                        maze[i, j] = O;
                    }
                }
            }
        }

        private static bool IsValidMove(int targetRow, int targetCol, char[,] maze)
        {
            if (targetRow >= maze.GetLength(0) || targetRow < 0 ||
                targetCol >= maze.GetLength(1) || targetCol < 0)
            {
                return false;
            }
            else if (maze[targetRow, targetCol] == X)
            {
                return false;
            }
            else if (maze[targetRow, targetCol] == F)
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
