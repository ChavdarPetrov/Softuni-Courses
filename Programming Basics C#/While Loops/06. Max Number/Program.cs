using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int max = int.MinValue;
            while (a != "Stop")
            {
                int b = int.Parse(a);
                if (b > max)
                {
                    max=b;
                }

                a = Console.ReadLine();

            }
                Console.WriteLine(max);
        }
    }
    }
