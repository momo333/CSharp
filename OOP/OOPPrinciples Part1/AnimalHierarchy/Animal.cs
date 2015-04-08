
namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Animal
    {
        private string name;
        private int age;
        private Gender sex;

        public Animal(string name, int age) : this(name, age, Gender.male)
        {

        }

        public Animal(string name, int age, Gender sex)
        {
            this.Sex = sex;
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name should have at least one symbol!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if(value<=0)
                {
                    throw new ArgumentException("The age should be at least zero!");
                }
                this.age = value;
            }
        }
        public Gender Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }
        
        public static IEnumerable<Tuple<string,double>>AverageAge(IEnumerable<Animal>animal)
        {
            var average = animal.GroupBy(a => a.GetType()).Select(a => new Tuple<string, double>(a.Key.Name, a.Average(an => an.Age)));
            return average;
        }
    }
}
