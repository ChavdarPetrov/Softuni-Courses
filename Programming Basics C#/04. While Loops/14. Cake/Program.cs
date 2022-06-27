using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int pieces = a * b;
            string take = "";
            int counter = 0;

            while (take != "STOP")
            {
                take = Console.ReadLine();

                if (take == "STOP")
                {
                    Console.WriteLine($"{pieces - counter} pieces are left.");
                    break;
                }
                counter += int.Parse(take);

                if (counter > pieces)
                {
                    Console.WriteLine($"No more cake left! You need {counter - pieces} pieces more.");
                    break;
                }
            }





        }
    }
}
