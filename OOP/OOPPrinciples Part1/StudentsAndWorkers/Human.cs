using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name should have at least one symbol!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name should have at least one symbol!");
                }
                this.lastName = value;
            }
        }
    }
}
