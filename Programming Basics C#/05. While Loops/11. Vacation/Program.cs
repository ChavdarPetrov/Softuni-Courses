using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int dayCount = 0;
            int spendDcount = 0;

            while (availableMoney < neededMoney)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                dayCount++;

                if (action == "save")
                {
                    availableMoney += money;
                    spendDcount = 0;
                }
                else
                {
                    availableMoney -= money;
                    spendDcount++;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    if (spendDcount >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{dayCount}");
                        break;
                    }
                }
            }



            if (availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {dayCount} days.");
            }



            
        }
    }   
}
