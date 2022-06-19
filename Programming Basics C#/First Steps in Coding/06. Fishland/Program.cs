using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            double shrimpKg = double.Parse(Console.ReadLine());

            double bonitoPrice = mackerelPrice * 1.6;
            double scadPrice = spratPrice * 1.8;
            double shrimpPrice = 7.5;

            double totalPrice = bonitoPrice * bonitoKg + scadKg * scadPrice + shrimpKg * shrimpPrice;


            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
