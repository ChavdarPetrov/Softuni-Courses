using System;

namespace _04.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {


            double travelCost = double.Parse(Console.ReadLine());

            int puzzleCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            int totalToys = puzzleCount + dollsCount + bearsCount + minionsCount + trucksCount;
            double totalPrice = puzzleCount * 2.6 + dollsCount * 3 + bearsCount * 4.1 + minionsCount * 8.2 + trucksCount * 2;
            
            if (totalToys >= 50)
            {
                totalPrice = totalPrice - totalPrice * 0.25;
            }

            double moneyLeft = totalPrice - totalPrice * 0.10;
            

            if (moneyLeft >= travelCost)
            { Console.WriteLine($"Yes! {moneyLeft - travelCost:f2} lv left."); }

            else

            {
                Console.WriteLine($"Not enough money! {travelCost-moneyLeft:f2} lv needed.");
            }
        }
    }
}