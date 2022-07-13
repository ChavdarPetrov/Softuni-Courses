using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 0;

            int grade = 1;
            double total = 0;

            while (grade <= 12)
            {
                double mark = double.Parse(Console.ReadLine());



                if (mark < 4)
                {
                    counter++;
                    if (counter == 2)
                    {

                        break;


                    }
                    continue;


                }
                    total += mark;
                    grade++;

            }
                if (grade > 12)
                {

                Console.WriteLine($"{name} graduated. Average grade: {total/12:f2}");
                }
                else
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                
            }
        }
    }
}