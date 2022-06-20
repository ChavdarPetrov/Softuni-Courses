using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    budget = 0.3 * budget;
                    place = "Camp";
                }
                else if (season == "winter")
                { budget = 0.7 * budget;
                    place = "Hotel";
                }


            }


            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    budget = 0.4 * budget;
                    place = "Camp";
                }
                else if (season == "winter")
                { budget = 0.8 * budget;
                    place = "Hotel";
                }


            }

            else
            {
                destination = "Europe";
                budget = 0.9 * budget;
                place = "Hotel";
            }
               
            
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {budget:f2}");
        
        }

        }
    }
