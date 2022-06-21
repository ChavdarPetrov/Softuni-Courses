using System;

namespace _10.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int nEven = int.Parse(Console.ReadLine());
                    evenSum += nEven;
                }
                else
                {
                    int nOdd = int.Parse(Console.ReadLine());
                    oddSum += nOdd;

                }
                }
                if (evenSum == oddSum)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {evenSum}");
                }
                else
                {

                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}
