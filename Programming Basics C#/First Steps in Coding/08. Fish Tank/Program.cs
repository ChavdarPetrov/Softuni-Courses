using System;

namespace _09.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            double volumeInLiters = volume / 1000;
            double usedSpace = percent / 100;

            double freeVolume = volumeInLiters * (1 - usedSpace);




            Console.WriteLine(freeVolume);
        }
    }
}
