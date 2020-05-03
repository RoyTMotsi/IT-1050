using System;


namespace Section_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("[Enter Information for p1]");
            Console.WriteLine("");

            Person person1 = new Person();
            person1.WhatIsYourNameAndAge(); 
            person1.CreateSpouseIfMarried();
            
            Console.WriteLine("");
            Console.WriteLine("[Enter Information for p2]");
            Console.WriteLine("");

            Person person2 = new Person();
            person2.WhatIsYourNameAndAge();
            person2.CreateSpouseIfMarried();

            Console.WriteLine("");
            Console.WriteLine("[Printing Results]");
            Console.WriteLine("");

            person1.PrintNameAndAge();
            person1.Spouse.PrintNameAndAge();
            person2.PrintNameAndAge();
            person2.Spouse.PrintNameAndAge();

            Console.WriteLine("Average Age: " + Person.AverageAge());
            Console.ReadKey();







        }
    }
}
