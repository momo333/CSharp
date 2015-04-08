namespace Shapes
{
    using System;
    class Circle : Shape
    {
        public const double PI = 3.14159;
        public Circle(double radius):base(radius*2, radius*2)
        {

        }
        public override double CalculateSurface()
        {
            return (2*Math.PI*this.Heght);
        }
    }
}
