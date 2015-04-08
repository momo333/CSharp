namespace Timer
{
    using System;
    public delegate void Ticker(int start);
    public class Timer
    {
        private int numbers;

        public int Numbers
        {
            get { return numbers; }
            set { this.numbers = value; }
        }

        public void Ticker(int start)
        {
            Console.WriteLine(this.numbers);
            this.numbers++;
        }
    }
}
