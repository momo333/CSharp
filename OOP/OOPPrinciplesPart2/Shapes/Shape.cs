namespace Shapes
{
    using System;
    public abstract class Shape
    {
        private double width;
        private  double height;
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Heght = height;
        }
        public double Width
        {
            get {return this.width;}
            set
            {
                //if(width<=0)
                //{
                //    throw new ArgumentException("The width should be bigger than 0!");
                //}
                this.width = value;
            }
        }
        public double Heght
        {
            get {return this.height;}
            set
            {
                //if(height<=0)
                //{
                //    throw new ArgumentException("The height should be bigger than zero!");
                //}
                this.height=value;
            }
        } 
        public abstract double CalculateSurface();
    }
}
