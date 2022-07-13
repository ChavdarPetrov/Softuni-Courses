using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int browsers = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double fines = 0;

            for (int i = 1; i <= browsers; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    fines += 150;
                }
                else if (website == "Instagram")
                {
                    fines += 100;
                }
                else if (website == "Reddit")
                {
                    fines += 50;
                }

                if (fines >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

               

            }
            if (fines < salary)
            {
                Console.WriteLine(salary - fines);
            }
        }
    }
}