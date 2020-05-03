using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        public static int Count;
        public static int SumOfAllAges;

        public static double AverageAge()
        {
            return (double)Person.SumOfAllAges / (double)Person.Count;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            Console.WriteLine(this.GetFullName() + " " + this.Age); 
        }
        public  void AskUserForSpouseNameAndAge() 
        {
            Console.Write("Enter Your Spouses Name          : ");
            this.FirstName = System.Console.ReadLine();
            Console.Write("Enter Your spouses Age           : ");
            this.Age = int.Parse(System.Console.ReadLine());
        }

        public void WhatIsYourNameAndAge()
        {
           Console.Write("Enter Your First Name             : ");
            this.FirstName = System.Console.ReadLine();

           Console.Write("Enter Your Last Name              : ");
            this.LastName = System.Console.ReadLine();

           Console.Write("Enter Your Age                    : ");
            this.Age = int.Parse(System.Console.ReadLine());
            
            Person.Count++;
            Person.SumOfAllAges += this.Age;
        }

        public void CreateSpouseIfMarried()
        {
            Console.Write("Are you married? (y/n) : ");

            if (Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                this.Spouse.AskUserForSpouseNameAndAge();
                this.Spouse.Spouse = this;
                this.Spouse.LastName = this.LastName;
            }



        }
    }
}