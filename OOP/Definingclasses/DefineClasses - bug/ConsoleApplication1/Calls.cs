using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Calls
    {
        private DateTime dateOfCall;
        private DateTime timeOfCall;
        private string calledNumber;
        private ulong duration;

        public Calls(DateTime date, DateTime time, string calledNumber, ulong duration)
        {
            this.dateOfCall = date;
            this.timeOfCall = time;
            this.calledNumber = calledNumber;
            this.duration = duration;
        }
        public DateTime DateOfCall
        {
            get
            {
                return this.dateOfCall;
            }
        }
        public DateTime TimeOfCall
        {
            get
            {
                return this.timeOfCall;
            }
        }
        public string CalledNumber
        {
            get
            {
                return this.calledNumber;
            }
        }
        public ulong Duration
        {
            get
            {
                return this.duration;
            }
        }
    }
}
