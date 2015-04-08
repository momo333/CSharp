using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPrat1
{
    public class Teacher : People, IComment
    {
        private List<Discipline> listDisciplines;
        public Teacher(string name, List<Discipline> listDisciplines)
            : base(name)
        {
            this.listDisciplines = new List<Discipline>(listDisciplines);
            this.Comments = new List<string>();
        }
        public List<Discipline> ListDisciplines
        {
            get
            {
                return this.listDisciplines;
            }
        }
        public List<string> Comments { get; set; }

        public void AddCommment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
