
//Problem Statement

//Watson gives four 3-dimensional points to Sherlock and asks him if they all lie in the same plane. Your task here is to help Sherlock.

//Input Format 
//First line contains T, the number of testcases. 
//Each test case consists of four lines. Each line contains three integers, denoting xi yi zi.

//Output Format 
//For each test case, print YES or NO whether all four points lie in same plane or not, respectively.

//Constraints 
//1 ≤ T ≤ 104 
//-103 ≤ xi,yi,zi ≤ 103

//Sample Input

//1
//1 2 0
//2 3 0
//4 0 0
//0 0 0
//Sample Output

//YES
//Explanation 
//All points have zi = 0, hence they lie in the same plane, and output is YES

//Download PDF

using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        while (count < number)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int z3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            int z4 = int.Parse(Console.ReadLine());

           int pointA = (y2 - y1) * (z3 - z1);
           int pointB = -1 * (z2 - z1) * (x3 - x1);
           int pointC = (x2 - x1) * (y3 - y1);
           int d = pointA * x1 + pointB * y1 + pointC * z1;
           int dd = pointA * x4 + pointB * y4 + pointC * z4;
            if (d == dd)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            count++;
        }
    }
}


