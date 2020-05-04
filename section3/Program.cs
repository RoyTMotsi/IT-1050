using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section3
{
    class Program
    {
        static void Main(string[] args)
        {

            Instructor instructor1 = new Instructor("John", "English");
            Instructor instructor2 = new Instructor("Mike", "Math");

            Student student1 = new Student("Jane", instructor1);
            Student student2 = new Student("Joe", instructor1);
            Student student3 = new Student("Melissa", instructor2);
            Student student4 = new Student("Matt", instructor2);

         
            instructor1.SetStudentGrade(student1, 95);
            instructor1.SetStudentGrade(student2, 85);
            instructor2.SetStudentGrade(student3, 90);
            instructor2.SetStudentGrade(student4, 92);

            student1.Print();
            student2.Print();
            student3.Print();
            student4.Print();
        }
    }
}
