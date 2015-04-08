namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    public class CalHstoryTest
    {
        static Random randGenerator = new Random();
        static GSM historyTest = new GSM("S4", "IPhone");
        public static void GSMCallHistory(int tests)
        {
            if (tests < 0)
            {
                Console.WriteLine("The number must be positive!");
            }
            else
            {
                for (int i = 0; i < tests; i++)
                {
                    Calls call = new Calls(DateTime.Now, DateTime.Now, "000000000000", (ulong)((i + 1) * randGenerator.Next(1, 100)));
                    historyTest.addCallToHistory(call);
                }

                for (int i = 0; i < historyTest.CallHistory.Count; i++)
                {
                    Console.WriteLine("Call: {0}", i+1);
                    Console.WriteLine("Date: {0:MM/dd/yy}",historyTest.CallHistory[i].DateOfCall);
                    Console.WriteLine("Time: {0:H:mm:ss}", historyTest.CallHistory[i].TimeOfCall);
                    Console.WriteLine("From: {0}", historyTest.CallHistory[i].CalledNumber);
                    Console.WriteLine("Duration: {0}",historyTest.CallHistory[i].Duration);
                }
            
                Console.WriteLine("The price per min is: ");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("All calls cost: ");
                Console.WriteLine(string.Format("{0}", historyTest.CallPrice(price)));

                Calls longetsCall = new Calls(DateTime.Now, DateTime.Now, "0", 0);

                foreach(var call in historyTest.CallHistory)
                {
                    if (call.Duration>=longetsCall.Duration)
                    {
                        longetsCall = call;
                    }
                }
                historyTest.DeleteCall(longetsCall);

                Console.WriteLine("Price after remomving the longeest call: ");
                Console.WriteLine(string.Format(new System.Globalization.CultureInfo("en-US"), "Total call price: {0:C}", historyTest.CallPrice(price)));
                historyTest.ClearRecord();

                foreach (var call in historyTest.CallHistory)
                {
                    Console.WriteLine(call);
                }
            }
        }
    }
}
