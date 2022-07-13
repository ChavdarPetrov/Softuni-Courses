using System;

namespace _02._Equal_Sums_Even_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());


            for (int i = firstN; i <= secondN; i++)
            {
                string currentN = i.ToString();

                int oddSum = 0;
                int evenSum = 0;


                for (int j = 0; j < currentN.Length; j++)
                {
                    int currentDigit = int.Parse(currentN[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;

                    }

                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");

                }

            }

        }
    }
}
