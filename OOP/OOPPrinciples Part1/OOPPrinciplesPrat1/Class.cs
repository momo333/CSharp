namespace OOPPrinciplesPrat1
{
    using System;
    using System.Collections.Generic;
    public class Class
    {
        private string identifier;
        private List<Student> students;
        private List<Teacher> teachers;

        public Class(string identifier, List<Student> students, List<Teacher> teacher)
        {
            this.UniqueIdentifier = identifier;
            this.students= new List<Student>();
            this.teachers = new List<Teacher>();
            this.Comments = new List<string>();
        }
        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }
        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
        }

        public string UniqueIdentifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Shuld have at least one symbol!");
                }
                this.identifier = value;
            }
            
        }
        public List<string> Comments { get; set; }
        public void AddCommment(string comment)
        {
            this.Comments.Add(comment);
        }

    }
}
