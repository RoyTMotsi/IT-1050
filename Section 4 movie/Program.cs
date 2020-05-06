using System;


namespace Section_4_movie
{
    class Program
    {
        static void Main(string[] args)
        {
            const double matineeChild = 3.99;
            const double matineeAdult = 5.99;
            const double matineeSenior = 4.50;

            //Evening Prices
            const double eveningChild = 6.99;
            const double eveningAdult = 10.99;
            const double eveningSenior = 8.50;

            //Concession Stand Prices
            const double smallSoda = 3.50;
            const double largeSoda = 5.99;
            const double hotDog = 3.99;
            const double popCorn = 4.50;
            const double candy = 1.99;

            double totalCostChildrenTickets = 0.00;
            double totalCostAdultsTickets = 0.00;
            double totalCostSeniorTickets = 0.00;

            double totCostSmallSodas = 0;
            double totCostLargeSoda = 0;
            double totCostHotDogs = 0;
            double totCostPopCorn = 0;
            double totCostCandy = 0;

            int numOfSmallSodas = 0;
            int numOfLargeSoda = 0;
            int numOfHotDogs = 0;
            int numOfPopCorn = 0;
            int numOfCandy = 0;

            int numChildrenTickets = 0;
            int numAdultsTickets = 0;
            int numSeniorTickets = 0;

            double totalCostOfMovieTrip = 0.00;
            double discount1 = 0.00;
            double discount2 = 0.00;
            double discount3 = 0.00;


            Console.WriteLine("is this This Ticket for the matinee showtime? [y/n]");
            string IsDayTime = Console.ReadLine().ToLower();

            //tickets
            Console.Write("How many children tickets do you need? ");
            numChildrenTickets = int.Parse(Console.ReadLine());
            Console.Write("How many adults tickets do you need? ");
            numAdultsTickets = int.Parse(Console.ReadLine());
            Console.Write("How many seniors' tickets do you need? ");
            numSeniorTickets = int.Parse(Console.ReadLine());

            int totNumOfTickets = numChildrenTickets + numAdultsTickets + numAdultsTickets;

            //concessions
            Console.Write("How many small sodas do you want? ");
            numOfSmallSodas = int.Parse(Console.ReadLine());
            Console.Write("How many large soda do you want? ");
            numOfLargeSoda = int.Parse(Console.ReadLine());
            Console.Write("How many hotdogs do you want? ");
            numOfHotDogs = int.Parse(Console.ReadLine());
            Console.Write("How many popcorn do you want? ");
            numOfPopCorn = int.Parse(Console.ReadLine());
            Console.Write("How many candy do you want? ");
            numOfCandy = int.Parse(Console.ReadLine());

            // Total Cost

            totCostSmallSodas = smallSoda * numOfSmallSodas;
            totCostLargeSoda = largeSoda * numOfLargeSoda;
            totCostHotDogs = hotDog * numOfHotDogs;
            totCostPopCorn = popCorn * numOfPopCorn;
            totCostCandy = candy * numOfCandy;

            double totalCostOfConcession = totCostSmallSodas + totCostLargeSoda + totCostHotDogs + totCostPopCorn + totCostCandy;

            if (IsDayTime == "y")
            {

                totalCostChildrenTickets = matineeChild * numChildrenTickets;
                totalCostAdultsTickets = matineeAdult * numAdultsTickets;
                totalCostSeniorTickets = matineeSenior * numSeniorTickets;

                double totalCostMatineeTickets = totalCostChildrenTickets + totalCostAdultsTickets + totalCostSeniorTickets;

                //Discount 1
                int min = numOfPopCorn < numOfLargeSoda ? numOfPopCorn : numOfLargeSoda;
                discount1 = min * 2.0;

                //Discount 3
                discount3 = (numOfCandy / 4) * 1.99;

                totalCostOfMovieTrip = totalCostChildrenTickets + totalCostAdultsTickets + totalCostSeniorTickets + totCostSmallSodas + totCostLargeSoda
                                       + totCostHotDogs + totCostPopCorn + totCostCandy - discount1 - discount3;

                double totDiscounts = discount1 + discount3;

                Console.Write("Total cost of the movie tickets: " + totalCostMatineeTickets);
                Console.Write("Total cost of concession : " + totalCostOfConcession);
                Console.Write("Total discounts: " + totDiscounts);
                Console.Write("Total cost of the movie outing: " + totalCostOfMovieTrip);

                System.Console.ReadKey();
            }
            else
            {
                totalCostChildrenTickets = eveningChild * numChildrenTickets;
                totalCostAdultsTickets = eveningAdult * numAdultsTickets;
                totalCostSeniorTickets = eveningSenior * numSeniorTickets;


                double totalCostEveningTickets = totalCostChildrenTickets + totalCostAdultsTickets + totalCostSeniorTickets;

                //Discount 1
                int min = numOfPopCorn < numOfLargeSoda ? numOfPopCorn : numOfLargeSoda;
                discount1 = min * 2.0;

                //Discount 2
                discount2 = (totNumOfTickets >= 3) && (numOfPopCorn > 0) ? 4.50 : 0;

                //Discount 3
                discount3 = (numOfCandy / 4) * 1.99;

                double totDiscounts = discount1 + discount2 + discount3;

                totalCostOfMovieTrip = totalCostChildrenTickets + totalCostAdultsTickets + totalCostSeniorTickets + totCostSmallSodas + totCostLargeSoda
                                       + totCostHotDogs + totCostPopCorn + totCostCandy - discount1 - discount2 - discount3;


                Console.Write("Total cost of the movie tickets: " + totalCostEveningTickets);
                Console.Write("Total cost of concession " + totalCostOfConcession);
                Console.Write("Total discounts: " + totDiscounts);
                Console.Write("Total cost of the movie outing: " + totalCostOfMovieTrip);

                System.Console.ReadKey();
            }
        }
    }
}
