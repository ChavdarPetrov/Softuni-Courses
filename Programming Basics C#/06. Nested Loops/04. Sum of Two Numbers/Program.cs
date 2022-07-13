using System;

namespace _04._Sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                        counter++;
                    if (i + j == n)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {n})");
                        return;
                    }
                   
                    
                        
                    
                }
            }

            
            
                Console.WriteLine($"{counter} combinations - neither equals {n}");

            

        }
    }
}
