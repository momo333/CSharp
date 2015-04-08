using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRange
{
    
    class Program
    {
        public static IEnumerable<Student>RangeAge(Student[] students)
        {
            var result = from student in students
                         where student.Age >= 18 && student.Age <= 24
                         select student;
            return result;
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[4];
            students[0] = new Student("Penka", "Penkova");
            students[1] = new Student("Ginka", "Ginkova");
            students[2] = new Student("Pesho", "Peshov");
            students[3] = new Student("Ivan", "Ivanov");
            var searchStudentByYears = RangeAge(students);

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            var sort = students.OrderByDescending(m => m.FirstName).ThenByDescending(m => m.SecondName);
            foreach (var student  in sort)
            {
                Console.WriteLine(student);
            }
            //LINQ
            var sortedLINQ = from student in students
                             orderby student.FirstName descending, student.SecondName descending
                             select student;
            foreach (var student in sortedLINQ)
            {
                Console.WriteLine(student);
            }
           
        }
    }
}
