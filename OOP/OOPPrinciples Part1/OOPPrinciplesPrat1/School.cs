namespace OOPPrinciplesPrat1
{
    using System;
    using System.Collections.Generic;
    public class School
    {
        private string name;
        private List<Class> classes;

        public School (string schoolName)
        {
            this.SchooldName = schoolName;
            classes = new List<Class>();
        }
        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
        }

        public string SchooldName
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("School name could not be null!");
                }
                this.name = value;
            }
        }
            public void AddClass (Class newClass)
        {
            this.classes.Add(newClass);
        }
        public void ClassGraduate (Class graduate)
        {
            this.classes.Add(graduate);
        }
    }
}
