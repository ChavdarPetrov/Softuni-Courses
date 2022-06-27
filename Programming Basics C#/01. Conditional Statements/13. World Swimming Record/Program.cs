using System;

namespace _06.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {

            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double ivanTime = distance * time;
            double timesSlowing = distance / 15.0;
            double totalSlowing = Math.Floor(timesSlowing) * 12.5;
            double totalIvan = ivanTime + totalSlowing;

            if (totalIvan < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalIvan:f2} seconds.");
            }
            else
            {

                Console.WriteLine($"No, he failed! He was {totalIvan-record:f2} seconds slower.");
            }
        }
    }
}
