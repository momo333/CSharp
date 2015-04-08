using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class GSM
    {
        private string model;
        private string manifacturer;
        private double? price;
        private string owner;
        private Display display;
        private Battery battery;
        private static List<Calls> callHistory = new List<Calls>();
        private static GSM Iphone = new GSM("IPhone 4S", "Apple");
        public GSM(string model, string manifacturer)
            : this(model, manifacturer, null, null)
        {

        }
        public GSM(string model, string manufacturer, double? price, string owner)
        {
            this.Manifacturer = manifacturer;
            this.Model = model;
            this.Owner = owner;
            this.Price = price;
            this.display = new Display();
            this.battery = new Battery();
        }
        public List<Calls> CallHistory
        {
            get
            {
                return callHistory;
            }
        }
        public GSM IPhone4S
        {
            get
            {
                return Iphone;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid model!");
                }
                this.model = value;
            }
        }
        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The manifacturer is Chinese bullShit!");
                }
                this.manifacturer = value;
            }
        }
        public double? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("Invalid Price!");
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public void addCallToHistory(Calls call)
        {
            callHistory.Add(call);
        }
        public bool DeleteCall(Calls call)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if(callHistory[i].DateOfCall ==call.DateOfCall &&
                    callHistory[i].TimeOfCall == call.TimeOfCall && 
                    callHistory[i].Duration == call.Duration && 
                    callHistory[i].CalledNumber ==call.CalledNumber)
                {
                    callHistory.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public double CallPrice(double callPrice)
        {
            double sum = 0;
            foreach (var item in callHistory)
            {
                sum += (double)(item.Duration) / 60;
            }
            return sum;
        }
        public void ClearRecord()
        {
            callHistory.Clear();
        }
    }
}
