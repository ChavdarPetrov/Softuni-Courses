
using System;

namespace While_Loop___Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum < n)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;

            }


            Console.WriteLine(sum);
        }
    }
}
