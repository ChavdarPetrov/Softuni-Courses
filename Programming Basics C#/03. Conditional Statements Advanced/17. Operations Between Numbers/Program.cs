using System;

namespace _06.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double sum = 0;

            if (symbol == '+' || symbol == '-' || symbol == '*')
            {
                string evenOrOdd = "odd";
                if (symbol == '+')

                    sum = n1 + n2;
                else if (symbol == '-')

                    sum = n1 - n2;

                else

                    sum = n1 * n2;

                if (sum % 2 == 0)
                {
                    evenOrOdd = "even";
                        }

                Console.WriteLine($"{n1} {symbol} {n2} = {sum} - {evenOrOdd}");


            }
            else if (symbol == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    sum = 1.0 * n1 / n2;
                    Console.WriteLine($"{n1} {symbol} {n2} = {sum:f2}");
                }

            }
            else if (symbol == '%')

            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    sum = n1 % n2;
                    Console.WriteLine($"{n1} {symbol} {n2} = {n1 % n2}");
                }
            }


        }
    }
}
