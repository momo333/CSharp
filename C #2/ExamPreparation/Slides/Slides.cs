﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slides
{
    class Ball
    {
        public Ball(Ball ball)
        {
            this.BallWidth = ball.BallWidth;
            this.BallHeight = ball.BallHeight;
            this.BallDepth = ball.BallDepth;
        }
        public Ball(int ballwidth, int ballHeight, int ballDepth)
        {
            this.BallWidth = ballwidth;
            this.BallHeight = ballHeight;
            this.BallDepth = ballDepth;

        }
        public int BallWidth { get; set; }
        public int BallHeight { get; set; }
        public int BallDepth { get; set; }

    }
    class Slides
    {
        private static int width, depth, height;
        private static string[, ,] cube;
        private static Ball cubeBall;
        static void Main(string[] args)
        {
            ReadInput();
            BallCommands();
        }

        private static void BallCommands()
        {
            while (true)
            {
                string currentCell = cube[cubeBall.BallWidth,
                    cubeBall.BallHeight, cubeBall.BallDepth];
                string[] splittedCell = currentCell.Split();
                string command = splittedCell[0];
                switch (command)
                {
                    case "S":
                        ProcessSlides(splittedCell[1]);
                        break;
                    case "T":
                        cubeBall.BallWidth = int.Parse(splittedCell[1]);
                        cubeBall.BallDepth = int.Parse(splittedCell[2]);
                        break;
                    case "B":
                        PrintMessage();
                        return;
                    case "E":
                        if (cubeBall.BallHeight == height - 1)
                        {
                            PrintMessage();
                            return;
                        }
                        else
                        {
                            cubeBall.BallHeight++;
                        }
                        break;
                    default: throw new ArgumentException("Invalid Command!");
                        break;
                }
            }
        }

        private static void ProcessSlides(string command)
        {
            Ball newCubeBall = new Ball(cubeBall);
            switch (command)
            {
                case "R": newCubeBall.BallHeight++;
                    newCubeBall.BallWidth++;
                    break;
                case "L": newCubeBall.BallHeight++;
                    newCubeBall.BallWidth--;
                    break;
                case "F": newCubeBall.BallHeight++;
                    newCubeBall.BallDepth--;
                    break;
                case "B": newCubeBall.BallHeight++;
                    newCubeBall.BallDepth++;
                    break;
                case "FL": newCubeBall.BallHeight++;
                    newCubeBall.BallWidth--;
                    newCubeBall.BallDepth--;
                    break;
                case "FR": newCubeBall.BallHeight++;
                    newCubeBall.BallDepth--;
                    newCubeBall.BallWidth++;
                    break;
                case "BL": newCubeBall.BallHeight++;
                    newCubeBall.BallWidth--;
                    newCubeBall.BallDepth++;
                    break;
                case "BR": newCubeBall.BallHeight++;
                    newCubeBall.BallWidth++;
                    newCubeBall.BallDepth++;
                    break;
                default: throw new ArgumentException("Invalid slide coordinate!");
                    if (IsPassable(newCubeBall))
                    {
                        cubeBall = new Ball(newCubeBall);
                    }
                    else
                    {
                        PrintMessage();
                        Environment.Exit(0);
                    }
            }
        }

        private static void PrintMessage()
        {
            string currentCell = cube[cubeBall.BallWidth,
                cubeBall.BallHeight, cubeBall.BallDepth];
            if (currentCell == "B" || cubeBall.BallHeight != height - 1)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
            Console.WriteLine("{0}{1}{2}", cubeBall.BallWidth,
                  cubeBall.BallHeight, cubeBall.BallDepth);
        }

        private static bool IsPassable(Ball ball)
        {
            if (ball.BallWidth >= 0 && ball.BallHeight >= 0 &&
                ball.BallDepth >= 0 && ball.BallWidth < width &&
                ball.BallHeight < height && ball.BallDepth < depth)
            {
                return true;
            }
            else
                return false;
        }
        private static void ReadInput()
        {
            string[] rawNum = Console.ReadLine().Split();
            width = int.Parse(rawNum[0]);
            height = int.Parse(rawNum[1]);
            depth = int.Parse(rawNum[2]);
            cube = new string[width, height, depth];

            for (int h = 0; h < height; h++)
            {
                string[] lineFragment = Console.ReadLine().Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                for (int d = 0; d < depth; d++)
                {
                    string[] cubeContent = lineFragment[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = cubeContent[w];
                    }
                }
            }
            string[] rawBallCoords = Console.ReadLine().Split();
            int ballWidth = int.Parse(rawBallCoords[0]);
            int ballDepth = int.Parse(rawBallCoords[1]);
            cubeBall = new Ball(ballWidth, 0, ballDepth);
        }
    }
}
