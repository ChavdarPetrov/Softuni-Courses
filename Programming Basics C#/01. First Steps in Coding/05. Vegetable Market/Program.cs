using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double vegetablesPerKg = double.Parse(Console.ReadLine());
            double fruitsPerKg = double.Parse(Console.ReadLine());
            int vegetablesKg = int.Parse(Console.ReadLine());
            int fruitsKg = int.Parse(Console.ReadLine());

            double sum = (vegetablesPerKg * vegetablesKg + fruitsPerKg * fruitsKg) / 1.94;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
