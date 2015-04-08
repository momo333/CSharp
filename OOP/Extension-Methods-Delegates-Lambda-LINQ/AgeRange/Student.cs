using System;
using System.Text;

namespace AgeRange
{
    public class Student
    {
        private string firstName;
        private string secondName;
        private int age;

        public Student (string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { this.secondName = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value;  }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0} {1}", this.FirstName, this.SecondName));
            return sb.ToString();
        }
    }
}
