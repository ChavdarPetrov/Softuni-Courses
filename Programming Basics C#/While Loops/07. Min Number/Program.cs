using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int min = int.MaxValue;
            while (a != "Stop")
            {
                int b = int.Parse(a);
                if (b < min)
                {
                    min = b;
                }

                a = Console.ReadLine();

            }
            Console.WriteLine(min);
        }
    }
}
