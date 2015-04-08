
namespace OOPPrinciplesPrat1
{
    using System;

    public abstract class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name should be at least one symbol!");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} ", this.Name);
        }
    }
}
