using System;

namespace While_Loop_EXCERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int freeSpace = a * b * c;
            int takenSpace = 0;

            string input = "";
            while (input != "Done")
            {
                input = Console.ReadLine();

                if (input == "Done")
                {
                    Console.WriteLine($"{freeSpace-takenSpace} Cubic meters left.");
                    break;
                }
                takenSpace += int.Parse(input);

                if (takenSpace >= freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {takenSpace-freeSpace} Cubic meters more.");
                    break;
                }

            }










        }
    }
}
