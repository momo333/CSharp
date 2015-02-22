using System;



class CoffeeMachine
{
    static void Main()
    {
        int tr1 =int.Parse(Console.ReadLine());
        int tr2 =int.Parse(Console.ReadLine());
        int tr3 =int.Parse(Console.ReadLine());
        int tr4 =int.Parse(Console.ReadLine());
        int tr5 =int.Parse(Console.ReadLine());

        double amount = double.Parse(Console.ReadLine());
        double priceDrink = double.Parse(Console.ReadLine());

        double changeAvailable = 0.05 * tr1 + 0.10 * tr2 + 0.20 * tr3 + 0.50 * tr4 + 1.0 * tr5;
        double change = amount - priceDrink;
        double leftMoney = changeAvailable - change;
        if (amount >= priceDrink && (changeAvailable > change))
        {
            Console.WriteLine("Yes {0:F2}",leftMoney );
        }
        else if(amount<=priceDrink)
        {
            Console.WriteLine("More {0:F2}", priceDrink - amount);
        }
        else if(amount>=priceDrink && (changeAvailable<change))
        {
            Console.WriteLine("No {0:F2}", Math.Abs(change - changeAvailable));
        }
    }
}

