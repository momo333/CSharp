using System;

class Program
{
    static void Main(string[] args)
    {
        int tomatoSeed = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeed = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoSeed = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeed = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeed = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beanSeed = int.Parse(Console.ReadLine());
        int area = 250;
        int remainarea = tomatoArea + cucumberArea + potatoArea +
            carrotArea + cabbageArea;
        int allVedgArea = tomatoArea + cucumberArea + potatoArea +
            carrotArea + cabbageArea;
        int beansArea = area - (tomatoArea + cucumberArea + potatoArea +
            carrotArea + cabbageArea);
        double tomatoSeedPrice = tomatoSeed * 0.5;
        double cucumberSeedPrice = cucumberSeed * 0.4;
        double potataoSeedPrice = potatoSeed * 0.25;
        double carrorSeedPrice = carrotSeed * 0.6;
        double cabbageSeedPrice = cabbageSeed * 0.3;
        double beansSeedPrice = beanSeed * 0.4;
        double price = tomatoSeedPrice + potataoSeedPrice + cabbageSeedPrice +
            carrorSeedPrice + cucumberSeedPrice + beansSeedPrice;
        if(allVedgArea>250)
        {
            Console.WriteLine("Total costs: {0:F2}", price);
            Console.WriteLine("Insufficient area");
        }
        else if(allVedgArea==250)
        {
            Console.WriteLine("Total costs: {0:F2}", price);
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Total costs: {0:F2}", price);
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        
    }
}

