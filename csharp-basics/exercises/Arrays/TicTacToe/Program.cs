using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] _board = new char[3, 3];
        private static char _currentPlayer = 'X';
        private static bool _gameOver = false;

        private static void Main(string[] args)
        {
            InitBoard();

            while (!_gameOver)
            {
                DisplayBoard();
                TakeTurn();
                CheckGameOver();
                SwitchPlayer();
            }

            Console.WriteLine("Game Over!");
            Console.ReadKey();
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    _board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("   0   1   2");
            Console.WriteLine("0  " + _board[0, 0] + " | " + _board[0, 1] + " | " + _board[0, 2]);
            Console.WriteLine("  ---+---+---");
            Console.WriteLine("1  " + _board[1, 0] + " | " + _board[1, 1] + " | " + _board[1, 2]);
            Console.WriteLine("  ---+---+---");
            Console.WriteLine("2  " + _board[2, 0] + " | " + _board[2, 1] + " | " + _board[2, 2]);
            Console.WriteLine();
        }

        private static void TakeTurn()
        {
            Console.WriteLine("Player " + _currentPlayer + ", it's your turn.");
            bool validInput = false;

            while (!validInput)
            {
                Console.Write("Enter the row (0-2): ");
                int row = int.Parse(Console.ReadLine());

                Console.Write("Enter the column (0-2): ");
                int col = int.Parse(Console.ReadLine());

                if (row >= 0 && row <= 2 && col >= 0 && col <= 2 && _board[row, col] == ' ')
                {
                    _board[row, col] = _currentPlayer;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }
        }

        private static void CheckGameOver()
        {
            if (CheckWin() || CheckDraw())
                _gameOver = true;
        }

        private static bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((_board[i, 0] == _currentPlayer && _board[i, 1] == _currentPlayer && _board[i, 2] == _currentPlayer) ||
                    (_board[0, i] == _currentPlayer && _board[1, i] == _currentPlayer && _board[2, i] == _currentPlayer))
                {
                    return true;
                }
            }

            if ((_board[0, 0] == _currentPlayer && _board[1, 1] == _currentPlayer && _board[2, 2] == _currentPlayer) ||
                (_board[0, 2] == _currentPlayer && _board[1, 1] == _currentPlayer && _board[2, 0] == _currentPlayer))
            {
                return true;
            }

            return false;
        }

        private static bool CheckDraw()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (_board[r, c] == ' ')
                        return false;
                }
            }

            return true;
        }

        private static void SwitchPlayer()
        {
            _currentPlayer = _currentPlayer == 'X' ? 'O' : 'X';
        }
    }
}
