using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPrat1
{
    public class TestSchool
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Milko",12),
                new Student("Morko",6),
                new Student("Pencho",13),
                new Student("Gencho",1),
                new Student("Traicho",2),
                new Student("Vlaicho",22),
                new Student("Pepi",3),
            };

            var disciplinesGancho = new List<Discipline>()
            {
                new Discipline("OOP",2,6),
                new Discipline("C#", 4,7),
            };
            var teacher = new Teacher("Mr. Jones",disciplinesGancho);

            var classJ = new Class("J", students, new List<Teacher>() { teacher });

            classJ.AddCommment("The students in this class are genious!");
            Console.WriteLine(classJ.UniqueIdentifier);
            Console.WriteLine("Students in class J: ");
            foreach (var student in students)
            {
                Console.WriteLine(student.Name + " " + student.UniqueClassNumber);
            }

            foreach (var teach in classJ.Teachers)
            {
                Console.WriteLine(teacher.Name + "-->");
                foreach (var course in teach.ListDisciplines)
                {
                    Console.WriteLine(course.NameDiscipline + "-" + course.NumberExercises + "-" + course.NumberLectures);
                }
            }
            var school = new School("My school");
            school.AddClass(classJ);
            foreach (var clas in school.Classes)
            {
                foreach (var comment in clas.Comments)
                {
                    Console.WriteLine(comment);
                }
            }
        }
    }
}
