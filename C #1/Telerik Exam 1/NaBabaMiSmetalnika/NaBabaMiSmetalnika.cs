using System;

public class Smetalnik
{
    public static void Main()
    {
        const int height = 8;
        int width = int.Parse(Console.ReadLine());
        string[,] matrix = new string[height, width];

        for (int row = 0; row < height; row++)
        {
            int number = int.Parse(Console.ReadLine());
            int position = 0;

            for (int col = width - 1; col >= 0; col--)
            {
                int lastBit = number & (1 << position);
                lastBit >>= position;
                if (lastBit != 0)
                {
                    matrix[row, col] = "1";
                }
                else
                {
                    matrix[row, col] = "0";

                }
                position++;
            }
        }

        string input = null;

        while (input != "stop")
        {
            int onesCount = 0;
            input = Console.ReadLine();
            if (input == "right")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if (col < 0)     //check if position is outside the array (by default -50 to 50)
                {
                    col = 0;
                }
                if (col >= width)
                {
                    col = width - 1;
                }

                for (int currCol = col; currCol < width; currCol++)
                {
                    if (matrix[row, currCol] == "1")    //counting strings = "1" after given position and removing them
                    {
                        matrix[row, currCol] = "0";
                        onesCount++;
                    }
                }

                for (int currCol = width - 1; onesCount > 0; onesCount--, currCol--)
                {
                    matrix[row, currCol] = "1";    // putting "1" from left to right until onesCount is = 0
                }

            }

            else if (input == "left")             // I do same things in reverce for command "left"
            {

                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if (col < 0)
                {
                    col = 0;
                }
                if (col >= width)
                {
                    col = width - 1;
                }

                for (int currCol = col; currCol >= 0; currCol--)
                {
                    if (matrix[row, currCol] == "1")
                    {
                        matrix[row, currCol] = "0";
                        onesCount++;
                    }
                }

                for (int currCol = 0; onesCount > 0; onesCount--, currCol++)
                {
                    matrix[row, currCol] = "1";
                }
            }

            else if (input == "reset") //putting all strings = "1" from left to right before that with same action as before
            {
                for (int row = 0; row < height; row++)
                {
                    onesCount = 0;

                    for (int currCol = 0; currCol < width; currCol++)
                    {
                        if (matrix[row, currCol] == "1")
                        {
                            matrix[row, currCol] = "0";
                            onesCount++;
                        }
                    }

                    for (int currCol = 0; onesCount > 0; onesCount--, currCol++)
                    {
                        matrix[row, currCol] = "1";
                    }
                }
            }
        }

        long result = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)  // convertting binary num to decimal and adding to result
        {
            string binNum = null;
            long decimalNum = 0;
            long digit = 0;
            int pow = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                binNum += matrix[row, col];
            }

            for (int i = binNum.Length - 1; i >= 0; i--)
            {
                digit = binNum[i] - '0';
                decimalNum += (long)(digit * (Math.Pow(2, pow)));
                pow++;
            }

            result += decimalNum;
        }

        int zeroColumnCounter = 0;

        for (int col = width - 1; col >= 0; col--) //counting columns that contain only "0"
        {
            int zeroesCounter = 0;
            for (int row = 0; row < height; row++)
            {
                if (matrix[row, col] == "0")
                {
                    zeroesCounter++;
                }
            }
            if (zeroesCounter == height)
            {
                zeroColumnCounter++;
            }

        }

        //print result

        Console.WriteLine(result * zeroColumnCounter);
    }

}































//using System;


//class Program
//{
//    static void reset()
//    {

//    }
//    static void MoveRight(uint[] nums, int width, int position, uint line)
//    {
//        if(position>=width)
//        {
//            position = 0;
//        }
//        else if(position<0)
//        {
//            position =width - 1;
//        }
//        int bitcounter = 0;
//        for (int i = position; i < width - 1; i++)
//        {
           
//            if(nums[line] & (uint)(1<<i)!=0)
//            {
//                bitcounter++;
//             uint mask =~(uint)(1<<i);
//             nums[line] &= nums[line];
//            }
//        }
//    }

//    static void MoveLeft(uint[] nums, int row, int col)
//    {
       
//    }
//    static void Main(string[] args)
//    {
//        int width = int.Parse(Console.ReadLine());     //width of the field
//        uint[] nums = new uint[8];
//        for (int i = 0; i < nums.Length; i++)
//        {
//            nums[i]=uint.Parse(Console.ReadLine());
//        }

//        while(true)
//        {
//            string command = Console.ReadLine();
//            switch(command)
//            {
//                case "left": 
//                    int line=int.Parse(Console.ReadLine());
//                    int position = int.Parse(Console.ReadLine());
//                    MoveLeft(nums, line, position); 
//                    break;
//                case "right":
//                    int line2=int.Parse(Console.ReadLine());
//                    int position2 = int.Parse(Console.ReadLine());
//                    MoveRight(nums, line2, position2); 
//                    break;
//                case "reset": reset();
//            }
//        }
//    }
//}



//using System;

//public class Smetalnik
//{
//    public static void Main()
//    {
//        const int height = 8;
//        int width = int.Parse(Console.ReadLine());
//        string[,] matrix = new string[height, width];

//        for (int row = 0; row < height; row++)
//        {
//            int number = int.Parse(Console.ReadLine());
//            int position = 0;

//            for (int col = width - 1; col >= 0; col--)
//            {
//                int lastBit = number & (1 << position);
//                lastBit >>= position;
//                if (lastBit != 0)
//                {
//                    matrix[row, col] = "1";
//                }
//                else
//                {
//                    matrix[row, col] = "0";

//                }
//                position++;
//            }
//        }

//        string input = null;

//        while (input != "stop")
//        {
//            int onesCount = 0;
//            input = Console.ReadLine();
//            if (input == "right")
//            {
//                int row = int.Parse(Console.ReadLine());
//                int col = int.Parse(Console.ReadLine());

//                if (col < 0)     //check if position is outside the array (by default -50 to 50)
//                {
//                    col = 0;
//                }
//                if (col >= width)
//                {
//                    col = width - 1;
//                }

//                for (int currCol = col; currCol < width; currCol++)
//                {
//                    if (matrix[row, currCol] == "1")    //counting strings = "1" after given position and removing them
//                    {
//                        matrix[row, currCol] = "0";          
//                        onesCount++;
//                    }
//                }

//                for (int currCol = width - 1; onesCount > 0; onesCount--, currCol--)
//                {
//                    matrix[row, currCol] = "1";    // putting "1" from left to right until onesCount is = 0
//                }
                
//            }

//            else if (input == "left")             // I do same things in reverce for command "left"
//            {

//                int row = int.Parse(Console.ReadLine());
//                int col = int.Parse(Console.ReadLine());

//                if (col < 0)    
//                {
//                    col = 0;
//                }
//                if (col >= width)
//                {
//                    col = width - 1;
//                }

//                for (int currCol = col; currCol >= 0; currCol--)
//                {
//                    if (matrix[row, currCol] == "1")
//                    {
//                        matrix[row, currCol] = "0";
//                        onesCount++;
//                    }
//                }

//                for (int currCol = 0; onesCount > 0; onesCount--, currCol++)
//                {
//                    matrix[row, currCol] = "1";
//                }
//            }

//            else if (input == "reset") //putting all strings = "1" from left to right before that with same action as before
//            {
//                for (int row = 0; row < height; row++)
//                {
//                    onesCount = 0;

//                    for (int currCol = 0; currCol < width; currCol++)
//                    {
//                        if (matrix[row, currCol] == "1")
//                        {
//                            matrix[row, currCol] = "0";
//                            onesCount++;
//                        }
//                    }

//                    for (int currCol = 0; onesCount > 0; onesCount--, currCol++)
//                    {
//                        matrix[row, currCol] = "1";
//                    }
//                }
//            }
//        }

//        long result = 0;

//        for (int row = 0; row < matrix.GetLength(0); row++)  // convertting binary num to decimal and adding to result
//        {
//            string binNum = null;
//            long decimalNum = 0;
//            long digit = 0;
//            int pow = 0;

//            for (int col = 0; col < matrix.GetLength(1); col++)
//            {
//                binNum += matrix[row, col];
//            }

//            for (int i = binNum.Length - 1; i >= 0; i--)
//            {
//                digit = binNum[i] - '0';
//                decimalNum += (long)(digit * (Math.Pow(2, pow)));
//                pow++;
//            }

//            result += decimalNum;
//        }

//        int zeroColumnCounter = 0;

//        for (int col = width - 1; col >= 0; col--) //counting columns that contain only "0"
//        {
//            int zeroesCounter = 0;
//            for (int row = 0; row < height; row++)
//            {
//                if (matrix[row, col] == "0")
//                {
//                    zeroesCounter++;
//                }
//            }
//            if (zeroesCounter == height)
//            {
//                zeroColumnCounter++;
//            }
            
//        }
        
//        //print result
		
//        Console.WriteLine(result * zeroColumnCounter);
//    }

//}