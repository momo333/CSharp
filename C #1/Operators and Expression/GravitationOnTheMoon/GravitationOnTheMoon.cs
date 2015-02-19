using System;
//Problem 2. Gravitation on the Moon
//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.


class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("The program calculates th e human weight on the moon");
        int weight = int.Parse(Console.ReadLine());

        double percerntGravitation = 0.17;
        double humanWeightOnTheMoon = weight * percerntGravitation;
        Console.WriteLine(humanWeightOnTheMoon);
    }
}

