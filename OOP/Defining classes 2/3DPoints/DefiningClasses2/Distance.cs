using System;


namespace DefiningClasses2
{
    public static class Distance
    {
        public static double CalculateDist(Point3D one, Point3D two)
        {
            double solveOne = (two.X - one.X) * (two.X - one.X);
            double solveTwo = (two.Y - one.Y) * (two.Y - one.Y);
            double solveThree = (two.Z - one.Z) * (two.Z - one.Z);
            double dist = Math.Sqrt(solveOne + solveTwo + solveThree);
            return dist;
        }
    }
}
