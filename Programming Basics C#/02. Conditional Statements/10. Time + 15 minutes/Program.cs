using System;

namespace _03._Time___15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            int totalMins = mins + hours * 60;
            int newTime = totalMins + 15;

            int newHours = newTime / 60;
            int newMins = newTime % 60;

            if (newHours > 23)
            {
                newHours = newHours - 24;
            }

            if (newMins<10)
            { Console.WriteLine($"{newHours}:0{newMins}"); }

            else

            { Console.WriteLine($"{newHours}:{newMins}"); }
        }
    }
}
