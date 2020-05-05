using System;


namespace Section_5_Loops_and_Arrays
{
    class Person
    {
        public string firstName = "name";
        public string lastName = "last";

        public Person(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public void Print()
        {
            string fullName = firstName + " " + lastName;
            System.Console.WriteLine(fullName);
        }
    }
}
