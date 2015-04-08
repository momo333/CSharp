namespace OOPPrinciplesPrat1
{
    using System;
    using System.Collections.Generic;
    public class Student : People, IComment
    {
        private int uniqueClassNum;

        public Student(string name, int uniqueNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueNumber;
            this.Comments = new List<string>();
        }
        public int UniqueClassNumber
        {
            get { return this.uniqueClassNum; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The number should be bigger than 0!");
                }
                this.uniqueClassNum = value;
            }
        }
        public List<string> Comments { get; private set; }

        public void AddCommment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
