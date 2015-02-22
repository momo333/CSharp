using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        char[,] matrix = new char[16, 16];
        List<string> answers = new List<string>();
        int cookies = 0;
        for (int rows = 0; rows < 16; rows++)
        {
            string digits = Console.ReadLine();
            for (int col = 0; col < digits.Length; col++)
            {
                matrix[rows, col] = digits[col];
            }
        }
        while (true)
        {
            string question = Console.ReadLine();
            int cookiePieceCount = 0;
            if (question == "paypal")
            {
                break;
            }
            if (question == "what is")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                if ((col == 0 && row == 0) || (col == 0 && row == 15))
                {
                    if (matrix[row, col] == '1' && matrix[row, col + 1] == '1')
                    {
                        answers.Add("broken cookie");
                        continue;
                    }
                    if (matrix[row, col] == '1' && matrix[row, col + 1] == 0)
                    {
                        answers.Add("cookie crumb");
                        continue;
                    }
                }
                if ((col == 15 && row == 0) || (col == 15 && row == 15))
                {
                    if (matrix[row, col] == '1' && matrix[row, col - 1] == '1')
                    {
                        answers.Add("broken cookie");
                        continue;
                    }
                    if (matrix[row, col] == '1' && matrix[row, col - 1] == '0')
                    {
                        answers.Add("cookie crumb");
                    }
                }
                if (matrix[row, col] == '0')
                {
                    answers.Add("smile");
                }
                if (row == 0 || row == 15)
                {
                    if (matrix[row, col - 1] == '1' && matrix[row, col + 1] == '1')
                    {
                        answers.Add("broken cookie");
                        continue;
                    }
                    if (matrix[row, col - 1] == '1' && matrix[row, col + 1] == '0')
                    {
                        answers.Add("cookie crumb");
                    }
                }
                else
                {
                    for (int i = row -1; i <= row+1; i++)
                    {
                        for (int j = col-1; j < col+1; j++)
                        {
                            if(matrix[i,j]=='1')
                            {
                                cookiePieceCount++;
                            }
                        }
                    }
                    if(cookiePieceCount==1)
                    {
                        answers.Add("cookie crumb");
                    }
                    if(cookiePieceCount>1 && cookiePieceCount<9)
                    {
                        answers.Add("broken cookie");
                    }
                    if(cookiePieceCount==9)
                    {
                        answers.Add("cookie");
                    }
                }
            }
            if(question=="buy")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                if(matrix[row,col]=='0')
                {
                    answers.Add("smile");
                   
                }
                else
                {
                    if(row==0 || row ==15)
                    {
                        answers.Add("Page");
                    }
                    else
                    {
                        for (int i = row -1; i <= row + 1; i++)
                        {
                            for (int j = col - 1; j <= col + 1; j++)
                            {
                                if (matrix[i, j] == '1')
                                {
                                    matrix[i, j] = '0';
                                    cookiePieceCount++;
                                }
                            }
                        }
                        if(cookiePieceCount<9)
                        {
                            answers.Add("page");
                        }
                        if(cookiePieceCount==0)
                        {
                            cookies++;
                        }
                    }
                }
            }

        }
        for (int i = 0; i < answers.Count; i++)
        {
            Console.WriteLine(answers[i]);
        }
        double price = 1.79;
        Console.WriteLine("{0:F2)}", cookies*price);
    }
}

