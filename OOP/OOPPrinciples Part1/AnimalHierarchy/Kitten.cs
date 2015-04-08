using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Kitten: Cat
    {
        public Kitten(string name, int age):base(name,age)
        {
            this.Sex = Gender.female;
        }

        public override string ToString()
        {
            return "MRrrrrrrrr!";
        }
    }
}
