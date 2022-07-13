using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            double sum = 0;

            while (destination != "End")
            {
            double budget = double.Parse(Console.ReadLine());
                sum = 0;
                while (sum < budget)
                {
                    sum += double.Parse(Console.ReadLine());
                  
                }

                
                    Console.WriteLine($"Going to {destination}!");

                



                destination = Console.ReadLine();
            }

















        }
    }
}
