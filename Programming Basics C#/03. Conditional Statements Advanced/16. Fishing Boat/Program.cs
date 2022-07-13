using System;

namespace _04.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishmans = int.Parse(Console.ReadLine());

            double price = 0;


            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;


                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;

                case "Winter":
                    price = 2600;

                    break;


            }

            if (fishmans <= 6)
            {
                price -= price * 0.1;
            }
            else if (fishmans <= 11)
            {
                price -= 0.15 * price;

            }

            else
            {
                price -= 0.25 * price;
            }




            if (fishmans % 2 == 0 && season != "Autumn")

            {
                price -= 0.05 * price;

            }

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {price-budget:f2} leva.");
            }
        }
    }
}