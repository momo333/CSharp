namespace ConsoleApplication1
{
    using System;
    class Test
    {
        public static void TestGSM(int tests)
        {
            GSM[] phones = new GSM[tests];

            for (int i = 0; i < tests; i++)
            {
                phones[i] = new GSM("Model {0} " + (i + 1), "Manifacturer " + (i + 1), i + 1, "Owner" + (i + 1));
                phones[i].Battery = new Battery("Model {0}" + (i+1), (i + 1), (i+1));
                phones[i].Display = new Display((i + 1) * 2.52, (i + 1));
            }
            GSM IPhone = new GSM("S4", "IPhone");
            Console.WriteLine(IPhone.IPhone4S);
        }

    }
}
