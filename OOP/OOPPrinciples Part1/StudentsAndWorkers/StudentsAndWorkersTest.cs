namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StudentsAndWorkersTest
    {
        static void Main(string[] args)
        {
            var classStudents = new List<Student>()
            {
                new Student("Student","One",6),
                new Student("Student","Two",5),
                new Student("Student","Three",4),
                new Student("Student","Four",6),
                new Student("Student","Five",4),
                new Student("Student","Six",4),
                new Student("Student","Seven",2),
                new Student("Student","Eight",5),
                new Student("Student","Nine",6),
                new Student("Student","Ten",3),
            };
            var sortStudent = classStudents.OrderBy(s => s.Grade);
            foreach (var student in sortStudent)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            var workers = new List<Worker>()
            {
                new Worker("Worker","One",1110,8),
                new Worker("Worker","Two",650,8),
                new Worker("Worker","Three",787,6),
                new Worker("Worker","Four",615,8),
                new Worker("Worker","Five",800,8),
                new Worker("Worker","Six",660,6),
                new Worker("Worker","Seven",834,2),
                new Worker("Worker","Eight",1050,12),
                new Worker("Worker","Nine",905,10),
                new Worker("Worker","Ten",789,4)
            };

            var sortedWorkers = workers.OrderBy(w => w.MoneyPeHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();
            List<Human> merge = new List<Human>(workers);
            foreach (var student in classStudents)
            {
                merge.Add(student);
            }
            var sortStudentAndWorkers = merge.OrderBy(s => s.FirstName).ThenBy(s => s.LastName);
            foreach (var element in sortStudentAndWorkers)
            {
                Console.WriteLine(element); 
            }
        }
    }
}
