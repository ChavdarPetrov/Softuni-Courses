using System;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {

            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumNylon = (nylon + 2) * 1.5;
            double sumPaint = (paint + 0.1 * paint) * 14.5;
            double sumRazreditel = razreditel * 5;
            double bags = 0.4;

            double materials = (sumNylon + sumPaint + sumRazreditel + bags);
            double sumWorkers = materials * 0.3 * hours;
            double finalSum = materials + sumWorkers;


            Console.WriteLine(finalSum);
        }
    }
}
