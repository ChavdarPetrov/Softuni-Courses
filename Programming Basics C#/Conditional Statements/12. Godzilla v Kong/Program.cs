using System;

namespace _05.Godzilla_v_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            if (statists > 150)
            {
                price = price - price * 0.1;
            }

            double totalPrice = decor + price * statists;

            if (totalPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice-budget:f2} leva more.");
            }

            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-totalPrice:f2} leva left.");

            }

          
        }
    }
}
