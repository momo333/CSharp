using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Frog: Animal,ISound
    {
        public Frog(string name, int age) : base(name, age)
        {

        }
        public Frog(string name, int age, Gender sex) : base(name,age,sex)
        {

        }
        public virtual string MakeSound()
        {
            return "Kwak, kwak!";
        }
    }
}
