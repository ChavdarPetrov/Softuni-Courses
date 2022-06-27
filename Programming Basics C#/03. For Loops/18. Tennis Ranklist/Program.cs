using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int finalPoints = 0;
            int wins = 0;

            for (int i = 1; i <= tournaments; i++)
            {
                string tour = Console.ReadLine();

                switch (tour)
                {
                    case "W":
                        finalPoints += 2000;
                        wins++;
                        break;
                    case "F":
                        finalPoints += 1200;
                        break;
                    case "SF":
                        finalPoints += 720;
                        break;

                }

                

                


            }
            Console.WriteLine($"Final points: {startingPoints+finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(finalPoints / tournaments *1.0)}");
            Console.WriteLine($"{wins*1.0 / tournaments* 100.0:f2}%");


        }
    }
}
