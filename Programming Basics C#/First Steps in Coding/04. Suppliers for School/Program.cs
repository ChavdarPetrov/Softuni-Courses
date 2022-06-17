using System;

namespace School_supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double pensTotal = pens * 5.8; 
            double markersTotal = markers * 7.2; 
            double preparationTotal = preparation * 1.2;

            double sum = pensTotal + markersTotal + preparationTotal;
            double discount = sum * percent / 100;
            double finalSum = sum - discount;


            Console.WriteLine(finalSum);
        }
    }
}
