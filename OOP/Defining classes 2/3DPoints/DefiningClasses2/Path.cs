
namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Path
    {
        private List<Point3D> paths;
        public Path()
        {
            this.paths = new List<Point3D>();
            StartPoint();
        }
       public void StartPoint()
        {
            this.paths.Add(Point3D.StartPoint);
        }
        public void AddPoint(Point3D point)
       {
           this.paths.Add(Point3D.StartPoint);
       }
        public void AddPoint(int x, int y, int z)
        {
            this.paths.Add(new Point3D(x, y, z));
        }

        public override string ToString()
        {
            StringBuilder stringbuild = new StringBuilder();
            int index = 0;
            foreach (var point in this.paths)
            {
                stringbuild.AppendFormat("Point #{0}-->", index);
                index++;
                stringbuild.AppendFormat(point.ToString() + "\n");
            }
            return stringbuild.ToString();
        }


    }
}
