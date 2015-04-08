

namespace IEnumerableExtensions
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            Console.WriteLine("Sum: {0}", array.Sum());
            Console.WriteLine("Product: {0}", array.Product());
            Console.WriteLine("Min: {0}", array.Min());
            Console.WriteLine("Max: {0}", array.Max());
            Console.WriteLine("Average: {0}", array.Average());
        }
    }
}
