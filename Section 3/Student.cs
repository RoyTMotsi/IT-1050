using System;


namespace Section_3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string name, Instructor teacher)
        {
            Name = name;
            Teacher = teacher;
            Grade = 0;
        }

        public void SetGrade(int grade)
        {
            Grade = grade;
        }

        public void Print()
        {  
        }
     




