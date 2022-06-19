using System;

namespace _08.Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunch = breakTime / 8.0;
            double rest = breakTime / 4.0;

            double freeTime = breakTime - lunch - rest;

            if (freeTime < episode)
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episode - freeTime)} more minutes.");
            }
            else
            {

                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(freeTime-episode)} minutes free time.");
            } 
        }
    }
}
