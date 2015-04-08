namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Hierarchy
    {
        static void Main(string[] args)
        {
            Frog frog = new Frog("Kerrmit", 1, Gender.male);
            Console.WriteLine("{0} says {1}", frog.Name, frog.MakeSound());
            Dog dog = new Dog("Lassie", 1, Gender.male);
            Console.WriteLine("{0} says {1}", dog.Name, dog.MakeSound());
            Tomcat tom = new Tomcat("Tommy", 2);
            Console.WriteLine("{0} says {1}, {2}",tom.Name, tom.MakeSound(), tom.Sex);
            Kitten kitty = new Kitten("Kitty", 2);
            Console.WriteLine("{0} says {1}, {2}", kitty.Name, kitty.MakeSound(), kitty.Sex);
            Animal[] animals = 
            {
                new Dog("Kudjo",2),
                new Tomcat("Tommy", 3),
                new Cat("Silvester",1),
                new Frog("Kerrmit",3),
                new Kitten("Sissy", 1),
                new Tomcat("Jechko",2),
                new Dog("Kudjo",2),
                new Tomcat("Baron", 3),
                new Cat("Kotio",5),
                new Frog("Baba Jaba",1),
                new Kitten("Megi", 1),
                new Tomcat("Smile",2),
                new Cat("Onix",3)
            };
            var averageAge = Animal.AverageAge(animals);
            foreach (var animal in averageAge)
            {
                Console.WriteLine(animal.Item1 + animal.Item2);
            }
        }
    }
}
