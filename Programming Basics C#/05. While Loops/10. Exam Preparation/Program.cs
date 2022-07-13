using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedMarks = int.Parse(Console.ReadLine());
            string taskName = "";
            int mark = 0;
            int failedAttempts = 0;
            int taskCount = 0;
            double markSum = 0;

            string input = Console.ReadLine();

            while (input != "Enough")
            {
                taskName = input;
                mark = int.Parse(Console.ReadLine());

                markSum += mark;
                taskCount++;

                if (mark <= 4)
                {
                    failedAttempts++;
                    if (failedAttempts == failedMarks)
                    {
                        Console.WriteLine($"You need a break, {failedAttempts} poor grades.");
                        break;

                    }

                }
                input = Console.ReadLine();


            }

            if (failedAttempts != failedMarks)
            {
                Console.WriteLine($"Average score: {markSum / taskCount:f2}");
                Console.WriteLine($"Number of problems: {taskCount}");
                Console.WriteLine($"Last problem: {taskName}");
            }

        }
    }
}