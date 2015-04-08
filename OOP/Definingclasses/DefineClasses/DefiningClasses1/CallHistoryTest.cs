namespace GSMInfo
{
    using System;
    public class CallHisoryTest
    {
        static GSM historyTest = new GSM("3310", "Nokia");
        static Random rand = new Random();

        public static void GSMCallHistory(int numberOfTest)
        {
            if (numberOfTest <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 0; i < numberOfTest; i++)
                {
                    string phoneNum = "0" + rand.Next(800000000, 999999999);
                    Call call = new Call(DateTime.Now, DateTime.Now, phoneNum, (ulong)((i + 1) * rand.Next(1, 100)));
                    historyTest.AddCallInHistory(call);
                }

                for (int i = 0; i < historyTest.CallHistory.Count; i++)
                {

                    Console.WriteLine("Call: {1} {0} Date: {2:MM/dd/yy} {0} Time: {3: H:mm:ss} {0} Phone Number: {4} {0} Duration: {5}",
                            Environment.NewLine, i + 1, historyTest.CallHistory[i].DateOfCall, historyTest.CallHistory[i].TimeOfCall,
                            historyTest.CallHistory[i].DialedNumber, historyTest.CallHistory[i].Duration);
                }
                Console.WriteLine();

                Console.Write("Enter call price per minute (in USD):");
                decimal price = 0.37m;           //price per min hardcore value

                Console.WriteLine("price before to remove the longes call");
                Console.WriteLine(string.Format(new System.Globalization.CultureInfo("en-US"), "Total call price: {0:C}", historyTest.CallPrice(price)));

                Call longestCall = new Call(DateTime.Now, DateTime.Now, "0", 0);

                foreach (var call in historyTest.CallHistory)
                {
                    if (call.Duration >= longestCall.Duration)
                    {
                        longestCall = call;
                    }
                }
                historyTest.DeleteCallFromHistory(longestCall);
                Console.WriteLine("Price after removing the longest call: ");
                Console.WriteLine(string.Format(new System.Globalization.CultureInfo("en-US"), "Total call price: {0:C}", historyTest.CallPrice(price)));

                historyTest.ClearHistory();          //clear numbers
                foreach (var call in historyTest.CallHistory)
                {
                    Console.WriteLine(call);
                }
            }
        }
    }
}