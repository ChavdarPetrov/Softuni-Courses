using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string amount = Console.ReadLine();
            double total = 0;
            while (amount != "NoMoreMoney")
            {

                double increase = double.Parse(amount);
                if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {increase:f2}");
                total += increase;
                amount = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:f2}");

        }
    }
}
