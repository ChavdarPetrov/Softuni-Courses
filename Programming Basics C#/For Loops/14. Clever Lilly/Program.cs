using System;

namespace _04._Clever_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            
            double sum = 0;

            for (int i = 1; i <=age; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i * 5 - 1;
                    
                }

                else
                {
                    sum += toyPrice;
                }
            }

        

            if (sum >= washingMachine)
            {
                Console.WriteLine($"Yes! {sum-washingMachine:f2}");
            }

            else
            {
                Console.WriteLine($"No! {washingMachine-sum:f2}");
            }




        }
    }
}
