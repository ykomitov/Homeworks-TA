namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {
        public static void Main(string[] arguments)
        {
            const int MAX_POINTS = 35;

            string command = string.Empty;
            char[,] playingField = CreatePlayingField();
            char[,] minesMatrix = PlaceMines();
            int pointsCounter = 0;
            bool isMine = false;
            bool gameStart = true;
            bool gameEnd = false;
            List<PointsCalculator> highscore = new List<PointsCalculator>(6);
            int row = 0;
            int col = 0;

            do
            {
                if (gameStart)
                {
                    Console.WriteLine("Let's play “Minesweeper”. Try to find the fields not containing any mines." +
                    "\r\n 'top' shows the highscore\r\n 'restart' starts a new game\r\n 'exit' closes the game!");
                    DrawPlayingField(playingField);
                    gameStart = false;
                }

                Console.Write("Please input row and column: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= playingField.GetLength(0) && col <= playingField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintHighscore(highscore);
                        break;
                    case "restart":
                        playingField = CreatePlayingField();
                        minesMatrix = PlaceMines();
                        DrawPlayingField(playingField);
                        isMine = false;
                        gameStart = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;
                    case "turn":
                        if (minesMatrix[row, col] != '*')
                        {
                            if (minesMatrix[row, col] == '-')
                            {
                                FillWithNumberOfNeighbouringMines(playingField, minesMatrix, row, col);
                                pointsCounter++;
                            }

                            if (MAX_POINTS == pointsCounter)
                            {
                                gameEnd = true;
                            }
                            else
                            {
                                DrawPlayingField(playingField);
                            }
                        }
                        else
                        {
                            isMine = true;
                        }

                        break;

                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (isMine)
                {
                    DrawPlayingField(minesMatrix);
                    Console.Write(
                        "\nBooom! You just stepped on a mine. You have {0} points. " + "Please enter a nickname: ", pointsCounter);

                    string nickname = Console.ReadLine();

                    PointsCalculator currentPlayerResult = new PointsCalculator(nickname, pointsCounter);

                    if (highscore.Count < 5)
                    {
                        highscore.Add(currentPlayerResult);
                    }
                    else
                    {
                        for (int i = 0; i < highscore.Count; i++)
                        {
                            if (highscore[i].Points < currentPlayerResult.Points)
                            {
                                highscore.Insert(i, currentPlayerResult);
                                highscore.RemoveAt(highscore.Count - 1);
                                break;
                            }
                        }
                    }

                    highscore.Sort((PointsCalculator player1, PointsCalculator player2) => player2.Name.CompareTo(player1.Name));
                    highscore.Sort((PointsCalculator player1, PointsCalculator player2) => player2.Points.CompareTo(player1.Points));
                    PrintHighscore(highscore);

                    playingField = CreatePlayingField();
                    minesMatrix = PlaceMines();
                    pointsCounter = 0;
                    isMine = false;
                    gameStart = true;
                }

                if (gameEnd)
                {
                    Console.WriteLine("\nYOU WIN!");
                    DrawPlayingField(minesMatrix);
                    Console.WriteLine("Please input your name: ");
                    string playerName = Console.ReadLine();
                    PointsCalculator playerPoints = new PointsCalculator(playerName, pointsCounter);
                    highscore.Add(playerPoints);
                    PrintHighscore(highscore);
                    playingField = CreatePlayingField();
                    minesMatrix = PlaceMines();
                    pointsCounter = 0;
                    gameEnd = false;
                    gameStart = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Thanks for playing.");
            Console.WriteLine("See you around.");
            Console.Read();
        }

        private static void PrintHighscore(List<PointsCalculator> bestPlayers)
        {
            Console.WriteLine("\nHIGHSCORES:");
            if (bestPlayers.Count > 0)
            {
                for (int i = 0; i < bestPlayers.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, bestPlayers[i].Name, bestPlayers[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The highscore list is empty!\n");
            }
        }

        private static void FillWithNumberOfNeighbouringMines(char[,] playingField, char[,] mineField, int row, int col)
        {
            char numberOfMines = CalculateNeighbouringMines(mineField, row, col);
            mineField[row, col] = numberOfMines;
            playingField[row, col] = numberOfMines;
        }

        private static void DrawPlayingField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] minefield = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    minefield[i, j] = '-';
                }
            }

            List<int> minesList = new List<int>();
            while (minesList.Count < 15)
            {
                Random random = new Random();
                int newMine = random.Next(50);
                if (!minesList.Contains(newMine))
                {
                    minesList.Add(newMine);
                }
            }

            foreach (int mine in minesList)
            {
                int col = mine / cols;
                int row = mine % cols;

                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                minefield[col, row - 1] = '*';
            }

            return minefield;
        }

        private static void PrintNumberOfNeighbouringMines(char[,] playingField)
        {
            int col = playingField.GetLength(0);
            int row = playingField.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (playingField[i, j] != '*')
                    {
                        char numOfNeighbouringMines = CalculateNeighbouringMines(playingField, i, j);
                        playingField[i, j] = numOfNeighbouringMines;
                    }
                }
            }
        }

        private static char CalculateNeighbouringMines(char[,] playingField, int col, int row)
        {
            int count = 0;
            int rows = playingField.GetLength(0);
            int cols = playingField.GetLength(1);

            if (col - 1 >= 0)
            {
                if (playingField[col - 1, row] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < rows)
            {
                if (playingField[col + 1, row] == '*')
                {
                    count++;
                }
            }

            if (row - 1 >= 0)
            {
                if (playingField[col, row - 1] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < cols)
            {
                if (playingField[col, row + 1] == '*')
                {
                    count++;
                }
            }

            if ((col - 1 >= 0) && (row - 1 >= 0))
            {
                if (playingField[col - 1, row - 1] == '*')
                {
                    count++;
                }
            }

            if ((col - 1 >= 0) && (row + 1 < cols))
            {
                if (playingField[col - 1, row + 1] == '*')
                {
                    count++;
                }
            }

            if ((col + 1 < rows) && (row - 1 >= 0))
            {
                if (playingField[col + 1, row - 1] == '*')
                {
                    count++;
                }
            }

            if ((col + 1 < rows) && (row + 1 < cols))
            {
                if (playingField[col + 1, row + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }

        public class PointsCalculator
        {
            private string name;
            private int points;

            public PointsCalculator()
            {
            }

            public PointsCalculator(string name, int points)
            {
                this.name = name;
                this.points = points;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Points
            {
                get { return this.points; }
                set { this.points = value; }
            }
        }
    }
}
