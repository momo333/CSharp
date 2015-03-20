using System;

class Program
{
    static void Main(string[] args)
    {
        const int numberOfLines = 16;
        char[,] matrix = new char[16, 16];

        int blueCapacit = 0;
        int redCapacit = 0;
        char redCenterCapacitators = 'R';
        char blueCenterCapacitatrors = 'B';

        for (int row = 0; row < numberOfLines; row++)
        {
            string rowSequence = Console.ReadLine();
            for (int col = 0; col < rowSequence.Length; col++)
            {
                char digit = rowSequence[col];
                matrix[row, col] = digit;
            }
        }

        //Capacitators 4
        for (int row = 1; row < numberOfLines-1; row++)
        {
            for (int col = 0; col < numberOfLines-1; col++)
            {
                if(matrix[row,col]=='0')
                {
                    int capacitatorPart = 0;
                    if(matrix[row - 1, col - 1] == '1' &&
                        matrix[row - 1, col] == '1' &&
                        matrix[row - 1, col + 1] == '1' &&
                        matrix[row, col - 1] == '1' &&
                        matrix[row, col + 1] == '1' &&
                        matrix[row + 1, col - 1] == '1' &&
                        matrix[row + 1, col] == '1' &&
                        matrix[row + 1, col + 1] == '1')
                    {
                        capacitatorPart = 8;
                    }
                    if(capacitatorPart==8 && col<numberOfLines/2)
                    {
                        redCapacit++;
                        matrix[row, col] = redCenterCapacitators;
                        if(redCapacit==6)
                        {
                            redCapacit--;
                        }
                    }
                    else if(capacitatorPart==8 && col>=numberOfLines)
                    {
                        blueCapacit++;
                        matrix[row, col] = blueCenterCapacitatrors;
                    }
                }
            }
        }
        while(true)
        {
            string command = Console.ReadLine();
            switch(command)
            {
                case "hover":
                    int row = int.Parse(Console.ReadLine());
                    int col = int.Parse(Console.ReadLine());
                    if(matrix[row,col]=='1')
                    {
                        Console.WriteLine('*');
                    }
                    else
                    {
                        Console.WriteLine('-');
                    }
                    break;
                case "operate":
                     row = int.Parse(Console.ReadLine());
                     col = int.Parse(Console.ReadLine());
                    if(matrix[row,col]=='1')
                    {
                        Console.WriteLine("missed");
                        int allCapacitators = redCapacit + blueCapacit;
                        Console.WriteLine(allCapacitators);
                        Console.WriteLine("BOOM");
                    }
                    if(matrix[row,col]=='R')
                    {
                        redCapacit--;
                        for (int i = row-1; i <= row+1; i++)
                        {
                            for (int j = col-1; j <=col+1; j++)
                            {
                                matrix[i, j] = '0';
                            }
                        }
                    }
                    if (matrix[row, col] == 'B')
                    {
                        blueCapacit--;
                        for (int i = row - 1; i <= row + 1; i++)
                        {
                            for (int j = col - 1; j <= col + 1; j++)
                            {
                                matrix[i, j] = '0';
                            }
                        }
                    }
                    break;
                case "cut":
                    command = Console.ReadLine();
                    if(command=="red")
                    {
                        if(redCapacit==0)
                        {
                            Console.WriteLine(blueCapacit);
                            Console.WriteLine("disarmed");
                            return;
                        }
                        else
                        {
                            Console.WriteLine(redCapacit);
                            Console.WriteLine("BOOM");
                            return;
                        }
                    }
                    else
                    {
                        if(blueCapacit==0)
                        {
                            Console.WriteLine(redCapacit);
                            Console.WriteLine("disarmed");
                            return;
                        }
                        else
                        {
                            Console.WriteLine(blueCapacit);
                            Console.WriteLine("BOOM");
                            return;
                        }
                    }
            }
        }
    }
}

