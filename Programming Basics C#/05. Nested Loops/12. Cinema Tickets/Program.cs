using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();

            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;

            while (film != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                int count = 0;

                string ticket = Console.ReadLine();

                while (ticket != "End")
                {
                    count++;

                    if (ticket == "student")
                    {
                        totalStudent++;
                    }
                    else if (ticket == "standard")
                    {
                        totalStandard++;
                    }
                    else if (ticket == "kid")
                    {
                        totalKid++;
                    }

                    if (count == freeSeats)
                    {
                        break;
                    }

                    ticket = Console.ReadLine();

                }
                  
                    Console.WriteLine($"{film} - {count*1.0/freeSeats*100.0:f2}% full.");


                    film = Console.ReadLine();
             //   freeSeats = int.Parse(Console.ReadLine());
                
            }

            int totalTickets = totalStudent + totalKid + totalStandard;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{totalStudent*1.0/totalTickets*100:f2}% student tickets.");
            Console.WriteLine($"{totalStandard*1.0/totalTickets*100:f2}% standard tickets.");
            Console.WriteLine($"{totalKid*1.0/totalTickets*100:f2}% kids tickets.");

        }
    }
}
