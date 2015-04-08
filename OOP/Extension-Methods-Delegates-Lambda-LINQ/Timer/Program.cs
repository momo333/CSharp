using System;
using System.Threading;

namespace Timer
{
    class Program
    {
        public delegate void CounterEventHandler();
        public event CounterEventHandler Counter;

        static void Main(string[] args)
        {
            Timer timerOne = new Timer();
            Ticker timer = new Ticker(timerOne.Ticker);

            while(true)
            {
                Thread.Sleep(200);
                timer(0);
            }
        }
    }
}
