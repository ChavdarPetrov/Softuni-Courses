using System;

namespace _03.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

       

            double totalPrice = 0;

            if (name == "Roses")
            {
                totalPrice = count * 5;
                if (count > 80)
                {

                    totalPrice = totalPrice - 0.1 * totalPrice;
                }
            }


            else if (name == "Dahlias")
            {
                totalPrice = count * 3.8;
                if (count > 90)
                {
                    totalPrice = totalPrice - 0.15 * totalPrice;
                }
            }


            else if (name == "Tulips")
            {
                totalPrice = count * 2.8;
                if (count > 80)
                {

                    totalPrice = totalPrice - 0.15 * totalPrice;
                }
            }


            else if (name == "Narcissus")
            {
                totalPrice = count * 3;
                if (count < 120 )
                {

                    totalPrice = totalPrice + 0.15 * totalPrice;
                }
            }


            else if (name == "Gladiolus")
            {
                totalPrice = count * 2.5;
                if (count < 80)
                {
                    totalPrice = totalPrice + 0.2 * totalPrice;
                }
            }


   

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {name} and {budget - totalPrice:f2} leva left.");
            }

            else 
                    {
                Console.WriteLine($"Not enough money, you need {totalPrice-budget:f2} leva more.");
            }
        }
    }
}