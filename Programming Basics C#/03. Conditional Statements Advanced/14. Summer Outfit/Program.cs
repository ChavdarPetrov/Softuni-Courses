using System;

namespace _02.Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {

            int degrees = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (degrees <= 18)
            {
                if (dayTime == "Morning")

                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (dayTime == "Afternnon")

                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }

                else 

                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (dayTime == "Morning")

                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (dayTime == "Afternnon")

                {
                    outfit = "T-shirt";
                    shoes = "Sandals";

                }

                else 

                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }
            }
            else 
            {
                if (dayTime == "Morning")

                {
                    outfit = "T-shirt";
                    shoes = "Sandals";
                }
                else if (dayTime == "Afternnon")

                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";

                }

                else 

                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }

            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
       
    }
            
        
    }
   
    

