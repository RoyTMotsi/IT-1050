using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Ask user their first name 

            Console.WriteLine("what is your fist name");
            string firstName = Console.ReadLine();

            //Ask user their middle initial 

            Console.WriteLine("what is your middle inital");
            string middleInitial = Console.ReadLine();

            //Ask user last name 

            Console.WriteLine("what is your lastname");
            string lastName = Console.ReadLine();

            //Concatenation of full name  

            string fullName = firstName + " " + middleInitial + " " + lastName;

            // Ask user height in feet 

            Console.WriteLine("what is your heigth in feet");
            int heightFeet = Convert.ToInt32(Console.ReadLine());

            // Ask user extra inches  

            Console.WriteLine(" how many inches after height in feet ");
            double heightInches = double.Parse(Console.ReadLine());

            const double multiplier = 2.54;
            const int inchesPerFoot = 12;
            double inches = (heightFeet * inchesPerFoot) + heightInches;
            double heightCM = inches * multiplier;

            // Ask user their age 

            Console.WriteLine(" whate is your age ");
            int age = int.Parse(Console.ReadLine());

            //Ask user if they are a citizen 

            Console.WriteLine("are you a citizen?");
            bool isCitizen = bool.Parse(Console.ReadLine());
            bool canVote = (age >= 18) && isCitizen;

            Console.WriteLine("Your full name is: '" + fullName + "'.");
            Console.WriteLine("Your height in CM is: '" + heightCM + "'.");
            Console.WriteLine("Your voter eligibility is: '" + canVote + "'.");
            Console.ReadKey();
        }
    }
}
