
namespace StudentNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Names
    {
        public static IEnumerable<Students> FindByName(Students[] names)
        {
            var result = from name in names
                         where name.FirstName.CompareTo(name.SecondName) < 0
                         select name;
            return result;
        }
        static void Main(string[] args)
        {
            Students[] names = new Students[4];
            names[0] = new Students("Penka", "Penkova");
            names[1] = new Students("Ginka", "Ginkova");
            names[2] = new Students("Pesho", "Peshov");
            names[3] = new Students("Ivan", "Ivanov");

            var search = FindByName(names);
            foreach (var item in search)
            {
                Console.WriteLine(item);
            }
        }
    }
}
