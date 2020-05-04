using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section3
{
    class Student
    {
       
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Teacher = Teacher;
        }
        public void SetGrade(int value)
        {
            Grade = value;
        }
        public void Print()
        {
            Console.WriteLine("Student's Name: " + Name);
            Console.WriteLine("Grade: " + Grade);
            Teacher.Print();
        }
    }
}
