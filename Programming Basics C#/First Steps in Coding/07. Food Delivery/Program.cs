using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chichkenTotal = chickenMenu * 10.35;
            double fishTotal = fishMenu * 12.4;
            double vegetarianTotal = vegetarianMenu * 8.15;

            double dessert = (chichkenTotal + fishTotal + vegetarianTotal) * 20 / 100;
            double delivery = 2.5;
            double orderTotal = chichkenTotal + fishTotal + vegetarianTotal + dessert + delivery ;


            Console.WriteLine(orderTotal);
        }
    }
}
