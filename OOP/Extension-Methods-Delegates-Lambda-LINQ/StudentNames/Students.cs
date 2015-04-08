

namespace StudentNames
{
    using System;
    using System.Text;
    public class Students
    {
        private string firstName;
        private string secondName;

        public Students(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0} {1}", this.firstName, this.secondName));
            return sb.ToString();
        }

    }
}
