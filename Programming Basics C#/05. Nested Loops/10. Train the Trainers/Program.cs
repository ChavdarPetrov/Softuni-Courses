using System;

namespace _04._Train_the_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double presentationEv = 0;
            double totalPresentationEv = 0;
            int totalPres = 0;
            while (presentationName != "Finish")
            {   
                presentationEv = 0;
                for (int i = 1; i <=n; i++)
                {   
                    double evaluation = double.Parse(Console.ReadLine());
                    presentationEv += evaluation;
                }
                    presentationEv = presentationEv / n;

                Console.WriteLine($"{presentationName} - {presentationEv:f2}.");

                totalPresentationEv += presentationEv;

                    totalPres++;

                presentationName = Console.ReadLine();
            }


            Console.WriteLine($"Student's final assessment is {totalPresentationEv/totalPres :f2}. ");


        }
    }
}
