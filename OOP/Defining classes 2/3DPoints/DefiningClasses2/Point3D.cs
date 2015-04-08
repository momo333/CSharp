
namespace DefiningClasses2
{
    using System;

    public struct Point3D

    {
        private static readonly Point3D starPoint;
        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public static Point3D StartPoint
        {
            get
            {
                return starPoint;
            }
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.X, this.Y, this.Z);
        }

    }
}
