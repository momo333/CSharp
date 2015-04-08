
namespace ConsoleApplication1
{
    using System;
    public class Display
    {
        private double? size;
        private int? numberColors;

        public Display()
        {
            this.size = null;
            this.numberColors = null;
        }

        public Display(double size, int numberColors)
        {
            this.size = size;
            this.numberColors = numberColors;
        }

        public override string ToString()
        {
            return string.Format("displaySize: {0}, displayColors: {1}", size,numberColors);
        }
    }
}
