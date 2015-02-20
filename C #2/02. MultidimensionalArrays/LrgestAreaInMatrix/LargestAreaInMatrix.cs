using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
//Problem 7.* Largest area in matrix
//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

namespace LargesAreaInMatrix
{
    class Program
    {
        static int dimention;
        const int CELL_FORBIDDEN = int.MinValue;
        static public int[,] matrix;
        private static void InputMatrix()
        {
            for (int i = 0; i < dimention; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < dimention; j++)
                {
                    matrix[i, j] = line[j] - '0';
                }
            }
        }
        static void Main(string[] args)
        {
            dimention = int.Parse(Console.ReadLine());
            matrix = new int[dimention, dimention];
            InputMatrix();
            int maxDfsCout = int.MinValue;
            for (int i = 0; i < dimention; i++)
            {
                for (int j = 0; j < dimention; j++)
                {
                    if (matrix[i, j] != CELL_FORBIDDEN)
                    {
                        int count = DFS(i, j);
                        maxDfsCout = Math.Max(maxDfsCout, count);
                    }
                }
            }
        }
        public class Pair
        {
            public int x, y;
            public Pair()
            {
                x = y = 0;
            }
            public Pair(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public static int DFS(int x, int y)
        {
            Stack<Pair> dfsStack = new Stack<Pair>();
            dfsStack.Push(new Pair(x, y));
            int result = 0;
            while(dfsStack.Count>0)
            {
                Pair coordinates = dfsStack.Pop();
                int elemCoordinates = matrix[coordinates.x, coordinates.y]; 
                if(elemCoordinates==CELL_FORBIDDEN)
                {
                    continue;
                }
                result++;
                matrix[coordinates.x, coordinates.y] = CELL_FORBIDDEN;
                Pair leftCoordinates = new Pair(coordinates.x, coordinates.y - 1);
                if(ValidCoordinates(leftCoordinates) && 
                    elemCoordinates==matrix[leftCoordinates.x,leftCoordinates.y])
                {
                    dfsStack.Push(leftCoordinates);
                }
                 Pair rightCoordinates = new Pair(coordinates.x-1, coordinates.y );
                if(ValidCoordinates(rightCoordinates) && 
                    elemCoordinates==matrix[rightCoordinates.x,rightCoordinates.y])
                {
                    dfsStack.Push(rightCoordinates);
                } Pair upCoordinates = new Pair(coordinates.x, coordinates.y - 1);
                if(ValidCoordinates(upCoordinates) && 
                    elemCoordinates==matrix[upCoordinates.x,upCoordinates.y])
                {
                    dfsStack.Push(upCoordinates);
                }
                 Pair downCoordinates = new Pair(coordinates.x-1, coordinates.y );
                if(ValidCoordinates(downCoordinates) && 
                    elemCoordinates==matrix[downCoordinates.x,downCoordinates.y])
                {
                    dfsStack.Push(downCoordinates);
                }
            }
            return result;
        }
        public static bool ValidCoordinates  (Pair coordinates)
        {
            bool result = (coordinates.x>=0)&& (coordinates.x<dimention) && (coordinates.y>=0) && (coordinates.y<dimention);
            return result;
        }
    }
}

