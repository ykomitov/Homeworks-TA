namespace TicTacToe.GameLogic
{
    using System;

    public class GameResultValidator : IGameResultValidator
    {
        public const char PositionNotFilled = '-';

        public GameResult GetResult(string board)
        {
            // check horizontally
            if (board[0] != PositionNotFilled && (board[0] == board[1] && board[1] == board[2]))
            {
                return GetWinningPlayer(board[0]);
            }

            if (board[3] != PositionNotFilled && (board[3] == board[4] && board[4] == board[5]))
            {
                return GetWinningPlayer(board[3]);
            }

            if (board[6] != PositionNotFilled && (board[6] == board[7] && board[7] == board[8]))
            {
                return GetWinningPlayer(board[6]);
            }

            // check vertically
            if (board[0] != PositionNotFilled && (board[0] == board[3] && board[3] == board[6]))
            {
                return GetWinningPlayer(board[0]);
            }

            if (board[1] != PositionNotFilled && (board[1] == board[4] && board[4] == board[7]))
            {
                return GetWinningPlayer(board[1]);
            }

            if (board[2] != PositionNotFilled && (board[2] == board[5] && board[5] == board[8]))
            {
                return GetWinningPlayer(board[2]);
            }

            // check diagonals
            if (board[0] != PositionNotFilled && (board[0] == board[4] && board[4] == board[8]))
            {
                return GetWinningPlayer(board[0]);
            }

            if (board[2] != PositionNotFilled && (board[2] == board[4] && board[4] == board[6]))
            {
                return GetWinningPlayer(board[2]);
            }

            // check if game should continue
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == PositionNotFilled)
                {
                    return GameResult.NotFinished;
                }
            }

            return GameResult.Draw;
        }

        public GameResult GetWinningPlayer(char c)
        {
            if (c == 'X')
            {
                return GameResult.WonByX;
            }
            else if (c == 'O')
            {
                return GameResult.WonByO;
            }
            else
            {
                throw new Exception("Oops... сomething bad happened! GetWinningPlayer received unexpected input!");
            }
        }
    }
}
