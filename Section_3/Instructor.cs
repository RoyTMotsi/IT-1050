using System;

namespace Section_3
{
    class Instructor
    {
        
        private string Name;
        private string CourseName;

        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public void Print()
        {
            Console.WriteLine("Instructor's name: " + Name);
            Console.WriteLine("Course Name: " + CourseName);
        }
    }
}
