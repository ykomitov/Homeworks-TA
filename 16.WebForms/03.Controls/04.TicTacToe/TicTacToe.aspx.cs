namespace _04.TicTacToe
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class TicTacToe : System.Web.UI.Page
    {
        private static char[,] matrix = new char[3, 3];
        private static int[] coordinatesX = new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };
        private static int[] coordinatesY = new int[] { 0, 1, 2, 0, 1, 2, 0, 1, 2 };
        private static int[,] tabIndexMap = new int[3, 3]
        {
            { 0, 1, 2 },
            { 3, 4, 5 },
            { 6, 7, 8 }
        };

        private static bool inGame = true;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonStartGame_Click(object sender, EventArgs e)
        {
            this.InitializeGameMatrix();

            foreach (Control c in this.GameContainer.Controls)
            {
                if (c is ImageButton)
                {
                    var currentImage = c as ImageButton;
                    currentImage.Enabled = true;
                    currentImage.ImageUrl = "images/blank.png";
                }
            }

            this.GameResultContainer.InnerText = string.Empty;
            inGame = true;
        }

        protected void MarkMove_Click(object sender, ImageClickEventArgs e)
        {
            string gameResult = "no result";
            ImageButton clickedImage = sender as ImageButton;

            if (inGame)
            {
                // Change the picture and disable the control
                clickedImage.Enabled = false;
                clickedImage.ImageUrl = "/images/cross.png";

                // Mark the move
                int index = int.Parse(clickedImage.TabIndex.ToString());
                matrix[coordinatesX[index], coordinatesY[index]] = 'x';
                gameResult = this.CheckGameResult();
                inGame = this.CheckGameState(gameResult);
            }

            if (inGame)
            {
                // Get a move from the server
                this.GetMoveFromServer();
                gameResult = this.CheckGameResult();
                inGame = this.CheckGameState(gameResult);
            }
            else
            {
                this.DisableControls();
            }
        }

        private bool CheckGameState(string gameResult)
        {
            if (gameResult != "no result")
            {
                this.GameResultContainer.InnerText = gameResult;
                return false;
            }

            return true;
        }

        private string CheckGameResult()
        {
            // Check horizontally
            if (matrix[0, 0] != '-' && matrix[0, 0] == matrix[0, 1] && matrix[0, 1] == matrix[0, 2])
            {
                return this.CheckWinningPlayer(matrix[0, 0]);
            }

            if (matrix[1, 0] != '-' && matrix[1, 0] == matrix[1, 1] && matrix[1, 1] == matrix[1, 2])
            {
                return this.CheckWinningPlayer(matrix[1, 0]);
            }

            if (matrix[2, 0] != '-' && matrix[2, 0] == matrix[2, 1] && matrix[2, 1] == matrix[2, 2])
            {
                return this.CheckWinningPlayer(matrix[2, 0]);
            }

            // Check vertically
            if (matrix[0, 0] != '-' && matrix[0, 0] == matrix[1, 0] && matrix[1, 0] == matrix[2, 0])
            {
                return this.CheckWinningPlayer(matrix[0, 0]);
            }

            if (matrix[0, 1] != '-' && matrix[0, 1] == matrix[1, 1] && matrix[1, 1] == matrix[2, 1])
            {
                return this.CheckWinningPlayer(matrix[0, 1]);
            }

            if (matrix[0, 2] != '-' && matrix[0, 2] == matrix[1, 2] && matrix[1, 2] == matrix[2, 2])
            {
                return this.CheckWinningPlayer(matrix[0, 2]);
            }

            // Check diagonals
            if (matrix[0, 0] != '-' && matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
            {
                return this.CheckWinningPlayer(matrix[0, 0]);
            }

            if (matrix[0, 2] != '-' && matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
            {
                return this.CheckWinningPlayer(matrix[0, 2]);
            }

            // Check for draw
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != '-')
                    {
                        counter++;
                    }
                }
            }

            if (counter == 9)
            {
                return "Game is draw!";
            }

            return "no result";
        }

        private string CheckWinningPlayer(char mark)
        {
            if (mark == 'x')
            {
                return "You win!";
            }
            else if (mark == 'o')
            {
                return "You lose!";
            }
            else
            {
                throw new NotSupportedException("Cannot determine winning player!");
            }
        }

        private void GetMoveFromServer()
        {
            int tabIndexOfMove = 99;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '-')
                    {
                        matrix[i, j] = 'o';
                        tabIndexOfMove = tabIndexMap[i, j];
                        this.MarkMoveFromServer(tabIndexOfMove);
                        return;
                    }
                }
            }
        }

        private void MarkMoveFromServer(int tabIndexOfMove)
        {
            foreach (Control c in this.GameContainer.Controls)
            {
                if (c is ImageButton)
                {
                    var clickedPosition = c as ImageButton;

                    if (clickedPosition.TabIndex == tabIndexOfMove)
                    {
                        clickedPosition.Enabled = false;
                        clickedPosition.ImageUrl = "/images/circle.png";
                        break;
                    }
                }
            }
        }

        private void InitializeGameMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = '-';
                }
            }
        }

        private void DisableControls()
        {
            foreach (Control c in this.GameContainer.Controls)
            {
                if (c is ImageButton)
                {
                    var currentImage = c as ImageButton;
                    currentImage.Enabled = false;
                }
            }
        }
    }
}