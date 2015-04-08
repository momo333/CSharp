using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person human = new Person("Pesho", 20);
            Person human2 = new Person("Gosho", 22);

            Console.WriteLine(human.ToString());
            Console.WriteLine(human2.ToString());
        }
    }
}
