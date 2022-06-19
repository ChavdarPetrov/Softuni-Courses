using System;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            double videoCardsPrice = 250.0;
            double procPrice = N * videoCardsPrice * 0.35;
            double ramPrice = N * videoCardsPrice * 0.1;

            double totalPrice = N * videoCardsPrice + M * procPrice + P * ramPrice;

            if (N > M)
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice-budget:f2} leva more!");
            }
        }
    }
}
