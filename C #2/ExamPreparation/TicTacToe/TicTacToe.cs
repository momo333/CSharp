using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        public const int EmptyCell = 0;
        public const int PlayerX = 1;
        public const int PlayerO = 2;
        public const int EvenGame = 3;
        private readonly byte[,] matrix;

        public TicTacToe(byte[,] matrix)
        {
            this.matrix = matrix;
        }
        private bool CompareBoard(byte a, byte b, byte c, byte d)
        {
            if (a == b && b == c && c == d)
            {
                return true;
            }
            else
                return false;
        }
        private byte Winner(int turn)
        {
            if (CompareBoard(matrix[0, 0], matrix[0, 1], matrix[0, 2], PlayerX)) // First row
            {
                return PlayerX;
            }
            if (CompareBoard(matrix[1, 0], matrix[1, 1], matrix[1, 2], PlayerX)) // Second row
            {
                return PlayerX;
            }
            if (CompareBoard(matrix[2, 0], matrix[2, 1], matrix[2, 2], PlayerX)) // Third row
            {
                return PlayerX;
            }
            if (CompareBoard(matrix[0, 0], matrix[1, 0], matrix[2, 0], PlayerX)) // First column
            {
                return PlayerX;
            }
            if (CompareBoard(matrix[0, 1], matrix[1, 1], matrix[2, 1], PlayerX)) // Second column
            {
                return PlayerX;
            }
            if (CompareBoard(matrix[0, 2], matrix[1, 2], matrix[2, 2], PlayerX)) // Third column
            {
                return PlayerX;
            }
            if (CompareBoard(matrix[0, 0], matrix[1, 1], matrix[2, 2], PlayerX)) // Diagonal 1
            {
                return PlayerX;
            }
            if (CompareBoard(matrix[0, 2], matrix[1, 1], matrix[2, 0], PlayerX)) // Diagonal 1
            {
                return PlayerX;
            }
            if (CompareBoard(matrix[0, 0], matrix[0, 1], matrix[0, 2], PlayerO)) // First row
            {
                return PlayerO;
            }
            if (CompareBoard(matrix[1, 0], matrix[1, 1], matrix[1, 2], PlayerO)) // Second row
            {
                return PlayerO;
            }
            if (CompareBoard(matrix[2, 0], matrix[2, 1], matrix[2, 2], PlayerO)) // Third row
            {
                return PlayerO;
            }
            if (CompareBoard(matrix[0, 0], matrix[1, 0], matrix[2, 0], PlayerO)) // First column
            {
                return PlayerO;
            }
            if (CompareBoard(matrix[0, 1], matrix[1, 1], matrix[2, 1], PlayerO)) // Second column
            {
                return PlayerO;
            }
            if (CompareBoard(matrix[0, 2], matrix[1, 2], matrix[2, 2], PlayerO)) // Third column
            {
                return PlayerO;
            }
            if (CompareBoard(matrix[0, 0], matrix[1, 1], matrix[2, 2], PlayerO)) // Diagonal 1
            {
                return PlayerO;
            }
            if (CompareBoard(matrix[0, 2], matrix[1, 1], matrix[2, 0], PlayerO)) // Diagonal 1
            {
                return PlayerO;
            }

            if (9 - turn == 0)
            {
                return EvenGame;
            }
            else
            {
                return EmptyCell;
            }
        }
        public int playerXwins = 0;
        public int playerOwins = 0;
        public int evenGames = 0;

        private void DoPredict(int turn)
        {
            byte winner = Winner(turn);
            if (winner != EmptyCell)
            {
                if (winner == PlayerX)
                {
                    playerXwins++;
                }
                else if (winner == PlayerO)
                {
                    playerOwins++;
                }
                else
                {
                    evenGames++;
                }
                return;
            }
            byte player;
            if (turn % 2 == 0)
            {
                player = PlayerX;
            }
            else
                player = PlayerO;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(matrix[i,j]==EmptyCell)
                    {
                        matrix[i, j] = player;
                        DoPredict(turn + 1);
                        matrix[i, j] = EmptyCell;
                    }
                }
            }
        }
        public void Predict()
        {
            byte turn = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(matrix[i,j]!=EmptyCell)
                    {
                        turn++;
                    }
                }
            }
            DoPredict(turn);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int cols = 3;
            byte[,] matrix = new byte[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < cols; j++)
                {
                    if (input[i] == '-')
                    {
                        matrix[i, j] = TicTacToe.EmptyCell;
                    }
                    if (input[i] == 'X')
                    {
                        matrix[i, j] = TicTacToe.PlayerX;
                    }
                    if (input[i] == 'O')
                    {
                        matrix[i, j] = TicTacToe.PlayerO;
                    }
                }
            }
            TicTacToe predictor = new TicTacToe(matrix);
            predictor.Predict();
            Console.WriteLine(predictor.playerXwins);
            Console.WriteLine(predictor.evenGames);
            Console.WriteLine(predictor.playerOwins);
        }
    }
}
