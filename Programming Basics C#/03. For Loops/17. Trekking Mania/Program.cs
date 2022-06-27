using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;


            for (int i = 1; i <= groupCount; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());

                if (peopleInGroup <= 5)
                {
                    musala+=peopleInGroup;
                }
               else if (peopleInGroup <= 12)
                {
                    monblan+=peopleInGroup;
                }
                else if (peopleInGroup <= 25)
                {
                    kilimandjaro+=peopleInGroup;
                }
                else if (peopleInGroup <= 40)
                {
                    k2+=peopleInGroup;
                }
                else
                {
                    everest+=peopleInGroup;
            
                }

                


            }


            double sum = musala + monblan + kilimandjaro + k2 + everest;

            Console.WriteLine($"{musala / sum * 100:f2}%");
            Console.WriteLine($"{monblan / sum * 100:f2}%");
            Console.WriteLine($"{kilimandjaro / sum * 100:f2}%");
            Console.WriteLine($"{k2 / sum * 100:f2}%");
            Console.WriteLine($"{everest / sum * 100:f2}%");



        }
    }
}
