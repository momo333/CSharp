using System;

class Bittris2
{
    static void Main(string[] args)
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[4, 8];
        int[] player = new int[8];
        int total = 0;

        //Logic
        for (int games = 0; games < n / 4; games++)
        {
            int row = 0;
            int input = 0;
            bool intParce = false;
            while (intParce == false)
            {
                intParce = int.TryParse(Console.ReadLine(), out input);
            }
            int i = 0;
            int score = 0;
            while (input > 0)
            {
                if (i < 8)
                {
                    player[i] = input % 2;
                }
                if (input % 2 == 1)
                {
                    score++;
                }
                input = input / 2;
                i++;
            }
            ////==================
            //for (int j = 0; j < 8; j++)
            //{
            //    Console.Write(player[7 - j]);
            //}
            //Console.WriteLine();
            ////=====================

            for (int tact = 0; tact < 3; tact++)
            {
                bool crush = false;
                char shift = char.Parse(Console.ReadLine());
                if (shift == 'L')
                {
                    if (player[7] != 1)
                    {
                        for (int position = 0; position < 7; position++)
                        {
                            player[7 - position] = player[6 - position];
                            if (position == 6)
                            {
                                player[0] = 0;
                            }
                        }
                    }
                    //    //==================
                    //    for (int j = 0; j < 8; j++)
                    //    {
                    //        Console.Write(player[7 - j]);
                    //    }
                    //    Console.WriteLine();
                    ////=====================
                }
                else if (shift == 'R')
                {
                    if (player[0] != 1)
                    {
                        for (int position = 0; position < 7; position++)
                        {
                            player[position] = player[position + 1];
                            if (position == 6)
                            {
                                player[7] = 0;
                            }
                        }
                    }
                    //    //==================
                    //    for (int j = 0; j < 8; j++)
                    //    {
                    //        Console.Write(player[7 - j]);
                    //    }
                    //    Console.WriteLine();
                    ////=====================
                }

                for (int col = 0; col < 8; col++)
                {
                    if ((player[col] == 1) && (matrix[row + 1, col] == 1))
                    {
                        crush = true;
                    }
                }
                if (crush == false)
                {
                    row++;
                }
                if (row == 3)
                {
                    crush = true;
                }
                if (row == 0 && crush)
                {
                    bool line = true;
                    for (int col = 0; col < 8; col++)
                    {
                        if (player[col] == 1)
                        {
                            matrix[row, col] = 1;
                            player[col] = 0;
                        }
                        if (matrix[row, col] == 0)
                        {
                            line = false;
                        }
                    }
                    if (line)
                    {
                        score = 10 * score;
                        total = total + score;
                        for (int col = 0; col < 8; col++)
                        {
                            matrix[row, col] = 0;
                        }
                        break;
                    }
                    else
                    {
                        total = total + score;
                        Console.WriteLine(total);
                        return;
                    }
                }
                else if (crush)
                {
                    bool line = true;
                    for (int col = 0; col < 8; col++)
                    {
                        if (player[col] == 1)
                        {
                            matrix[row, col] = 1;
                            player[col] = 0;
                        }
                        if (matrix[row, col] == 0)
                        {
                            line = false;
                        }
                    }
                    if (line)
                    {
                        score = 10 * score;
                        for (int j = 0; j <= row; j++)
                        {
                            for (int col = 0; col < 8; col++)
                            {
                                if (j == row)
                                {
                                    matrix[0, col] = 0;
                                }
                                else
                                    matrix[row - j, col] = matrix[row - j - 1, col];
                            }
                        }
                    }
                    total = total + score;
                }
                //Console.WriteLine("row = " + row);
            }
            ////=============================
            //for (int j = 0; j < 4; j++)
            //{
            //    for (int col = 0; col < 8; col++)
            //    {
            //        Console.Write(matrix[j, 7 - col]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Score = " + score);
            //Console.WriteLine("TOTAL = " + total);
            //==============================
        }

        //Output
        Console.WriteLine(total);
    }
}
