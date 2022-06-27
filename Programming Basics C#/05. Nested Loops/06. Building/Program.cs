using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i > 0 ; i--)
            {
                for (int j = 0; j < b; j++)
                { 
                    if (i == a)
                    {
                        Console.Write($"L{i}{j} ");
                        continue;

                    }

                     if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                        Console.WriteLine();

            }






                   }
    }
}
