namespace OOPPrinciplesPrat1
{
    using System;
    using System.Collections.Generic;

    public class Discipline: IComment
    {
        private string nameDiscipline;
        private int numLectures;
        private int numExcerseces;

        public Discipline(string nameDiscipline, int numberLectures, int numberExercises)
        {
            this.NameDiscipline = nameDiscipline;
            this.NumberLectures = numberLectures;
            this.NumberExercises = numberExercises;
            this.Comments = new List<string>();
        }
        public string NameDiscipline
        {
            get { return this.nameDiscipline; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name should be at least one symbol");
                }
                this.nameDiscipline = value;
            }
        }
        public int NumberLectures
        {
            get { return this.numLectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("The number of lectures should be >0!");
                }
                this.numLectures = value;
            }
        }
        public int NumberExercises
        {
            get { return this.numExcerseces; }
            set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("The number of lectures should be > 0!");
                }
                this.numExcerseces = value;
            }
        }
        public List<string> Comments { get; set; }

        public void AddCommment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
