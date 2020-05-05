using System;


namespace Section_5_Loops_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] someperson = new Person[3];
            someperson[0] = new Person("Mike", "Tyson");
            someperson[1] = new Person("Floyd", "Mayweather");
            someperson[2] = new Person("Lebron", "James");


            foreach (Person person in someperson)
            {
                person.Print();
            }

            System.Console.ReadLine();

        }
    }
}
