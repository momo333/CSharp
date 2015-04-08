namespace Person
{
    using System;
    public class Person
    {
        private string name;
        private uint? age;

        public Person(string name, uint? age)
        {
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
                    throw new ArgumentException("The name should be at least one symbol!");
                }
                this.name = value;
            }
        }
        public uint? Age
        {
            get { return this.age; }
            set
            {
               if(value<0)
               {
                   throw new ApplicationException("The age should be greater than 0!");
               }
               this.age = value;
            }
        }
        public override string ToString()
        {
            return this.age == null ?
                string.Format("Name: " + this.name + Environment.NewLine + "Age: Age not specified.") :
                string.Format("Name: " + this.name + Environment.NewLine + "Age: " + this.age);
        }
    }
}
