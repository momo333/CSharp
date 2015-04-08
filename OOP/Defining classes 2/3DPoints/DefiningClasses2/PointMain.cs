using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    class PointMain
    {
        static void Main(string[] args)
        {
            Point3D one = new Point3D(1, 2, 3);
            Point3D two = new Point3D(4, 5, 6);
            Point3D three = Point3D.StartPoint;
            Console.WriteLine(three);
            double distance = Distance.CalculateDist(one, two);
            Console.WriteLine(distance);

            Path path = new Path();
            path.AddPoint(one);
            Console.WriteLine(path);
            path.AddPoint(two);

            PathStorage.WritePathFile(@"..\..\test", path);
            Path newPath = PathStorage.ReadFromFile(@"..\..\testMethod.txt");
            Console.WriteLine(newPath);
            
        }
    }
}
