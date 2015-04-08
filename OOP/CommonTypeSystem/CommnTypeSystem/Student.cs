namespace CommnTypeSystem
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Net.Mail;
    public  class Student : ICloneable, IComparable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SocialNumber { get; set; }
        public string Adress { get; set; }
        public long  MobileNumber { get; set; }
        public string EmailAdress { get; set; }
        public string Course { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        public Student (string firstName, string middleName, string lastName, 
            ulong ssn, string pernAdress, long mobileNumber,string emailAdress )
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialNumber = ssn;
            this.Adress = pernAdress;
            this.MobileNumber = mobileNumber;
            this.EmailAdress = emailAdress;
        }

        public void UniversityInfo(University university, string course, Faculty faculty, Specialty specialty)
        {
            this.University = university;
            this.Course = course;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public object Clone()
        {
            Student student = new Student(this.FirstName, this.MiddleName, this.LastName, this.SocialNumber,
                this.Adress, this.MobileNumber, this.EmailAdress);
            student.UniversityInfo(this.University, this.Course, this.Faculty, this.Specialty);
            return student;
        }

        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }

            if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }
            if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }
            if (this.SocialNumber.CompareTo((obj as Student).SocialNumber) != 0)
            {
                return this.SocialNumber.CompareTo((obj as Student).SocialNumber);
            }

            return 0;
        }
        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) return false;
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) return false;
            if (!this.LastName.Equals((obj as Student).LastName)) return false;
            if (!this.SocialNumber.Equals((obj as Student).SocialNumber)) return false;
            if (!this.MobileNumber.Equals((obj as Student).MobileNumber)) return false;
            if (!this.Adress.Equals((obj as Student).Adress)) return false;
            if (!this.EmailAdress.Equals((obj as Student).EmailAdress)) return false;
            if (!this.Faculty.Equals((obj as Student).Faculty)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;
            if (!this.University.Equals((obj as Student).University)) return false;
            if (!this.Specialty.Equals((obj as Student).Specialty)) return false;

            return true;
        }
        public override int GetHashCode()
        {
            return this.SocialNumber.GetHashCode() ^ this.MobileNumber.GetHashCode();
        }
        public static bool operator ==(Student studentOne, Student studentTwo)
        {
            return studentOne.Equals(studentTwo);
        }

        public static bool operator !=(Student studentOne, Student studentTwo)
        {
            return !(studentOne.Equals(studentTwo));
        }
        public override string ToString()
        {
            StringBuilder printer = new StringBuilder();

            printer.Append(this.FirstName + " ");
            printer.Append(this.MiddleName + " ");
            printer.Append(this.LastName);
            printer.AppendLine(this.SocialNumber.ToString());
            printer.AppendLine(this.Adress);
            printer.AppendLine(this.MobileNumber.ToString());
            printer.AppendLine(this.EmailAdress);
            printer.AppendLine(this.Course.ToString());
            printer.AppendLine(this.University.ToString());
            printer.AppendLine(this.Faculty.ToString());
            printer.AppendLine(this.Specialty.ToString());

            return printer.ToString();
        }

    }
}
