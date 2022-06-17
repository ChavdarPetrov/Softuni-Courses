using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double sneakers = tax - tax * 40 / 100;
            double jersey = sneakers - sneakers * 20 / 100;
            double ball = jersey / 4;
            double accessories = ball / 5;

            double total = tax + sneakers + jersey + ball + accessories;


            Console.WriteLine(total);
        }
    }
}
