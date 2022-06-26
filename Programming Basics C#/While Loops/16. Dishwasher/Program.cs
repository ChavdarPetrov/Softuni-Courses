using System;

namespace _08._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int tickets1 = int.Parse(Console.ReadLine());
            int tickets2 = int.Parse(Console.ReadLine());
            double ticket1Price = double.Parse(Console.ReadLine());
            double carePrice = double.Parse(Console.ReadLine());

            double ticket2Price = 0.3 * ticket1Price;

            double profit = 0.2 * ((tickets1 * (ticket1Price + carePrice)+(ticket2Price+carePrice)*tickets2));

            Console.WriteLine($"The profit of your agency from {name} tickets is {profit:f2}lv.");



        }
    }
}
