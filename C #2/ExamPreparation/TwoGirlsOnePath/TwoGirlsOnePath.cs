namespace TwoGirlsOnePath
{
    using System;
    using System.Numerics;

    class TGOP
    {
        static long[] path;

        static long mollyPosition;
        static long dollyPosition;

        static BigInteger mollyFlowers;
        static BigInteger dollyFlowers;

        static bool mollyEnded;
        static bool dollyEnded;

        static string winner;

        static void Initialize()
        {
            path = ReadPath();

            mollyPosition = 0;
            dollyPosition = path.Length - 1;

            mollyFlowers = path[mollyPosition];
            dollyFlowers = path[dollyPosition];

            mollyEnded = false;
            dollyEnded = false;

            winner = "Draw";
        }

        static long[] ReadPath()
        {
            string[] pathParts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] pathNumbers = new long[pathParts.Length];

            for (int i = 0; i < pathNumbers.Length; i++)
            {
                pathNumbers[i] = long.Parse(pathParts[i]);
            }

            return pathNumbers;
        }

        static void StartGame()
        {
            if (CheckPathForFlowers())
            {
                return;
            }

            long mollyOffset = path[mollyPosition];
            long dollyOffset = path[dollyPosition];

            path[mollyPosition] = 0;
            path[dollyPosition] = 0;

            while (true)
            {
                mollyPosition = mollyPosition + mollyOffset;
                if (mollyPosition >= path.Length)
                {
                    mollyPosition %= path.Length;
                }

                dollyPosition = dollyPosition - dollyOffset;
                if (dollyPosition < 0)
                {
                    dollyPosition = path.Length + (dollyPosition % path.Length);
                    if (dollyPosition == path.Length)
                    {
                        dollyPosition = 0;
                    }
                }

                if (mollyPosition != dollyPosition)
                {
                    mollyFlowers += path[mollyPosition];
                    dollyFlowers += path[dollyPosition];
                }
                else
                {
                    mollyFlowers += path[mollyPosition] / 2;
                    dollyFlowers += path[dollyPosition] / 2;
                }

                if (CheckPathForFlowers())
                {
                    break;
                }

                mollyOffset = path[mollyPosition];
                dollyOffset = path[dollyPosition];

                if (mollyPosition != dollyPosition)
                {
                    path[mollyPosition] = 0;
                    path[dollyPosition] = 0;
                }
                else
                {
                    path[mollyPosition] = 1;
                }
            }
        }

        static bool CheckPathForFlowers()
        {
            if (path[mollyPosition] == 0 || path[dollyPosition] == 0)
            {
                if (path[mollyPosition] == 0)
                {
                    mollyEnded = true;
                }

                if (path[dollyPosition] == 0)
                {
                    dollyEnded = true;
                }

                return true;
            }

            return false;
        }

        static void CalculateWinner()
        {
            if (mollyEnded && !dollyEnded)
            {
                winner = "Dolly";
            }
            else if (!mollyEnded && dollyEnded)
            {
                winner = "Molly";
            }
        }

        static void PrintResult()
        {
            Console.WriteLine(winner);
            Console.WriteLine(mollyFlowers + " " + dollyFlowers);
        }

        static void Main()
        {
            Initialize();
            StartGame();
            CalculateWinner();
            PrintResult();
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Numerics;

//namespace TwoGirlsOnePath
//{
//    class TwoGirlsOnePath
//    {
//        static void Main(string[] args)
//        {
//            int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); //po-bavno e :)
//            bool[] array = new bool[data.Length];
//            BigInteger mollyFlowers = 0;
//            BigInteger dollyFlowers = 0;
//            BigInteger mollyIndex = 0;
//            BigInteger dollyIndex = data.Length-1;
//                data[(int)mollyIndex] = 0;
//                data[(int)dollyIndex] = 0;
//            string winner = "";
//            while(true)
//            {
//                if(data[(int)mollyIndex]==0 || data[(int)dollyIndex]==0)
//                {
//                    if(data[(int)mollyIndex]==0)
//                    {
//                        winner = "Dolly";
//                    }
//                    else if(data[(int)dollyIndex])
//                    {

//                    }
//                    break;
//                }
//                BigInteger currnetMollyFlowers = data[(int)mollyIndex];
//                BigInteger currentDollyIndex = data[(int)dollyIndex];
                
//                mollyIndex += (int)(mollyIndex + currnetMollyFlowers) % data.Length;
//                dollyIndex += (int)(  dollyIndex - currnetMollyFlowers) / data.Length;
//                {
//                    if(dollyIndex<0)
//                    {
//                        dollyIndex += data.Length;
//                    }
//                }
//            }

//        }
//    }
//}
