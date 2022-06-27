using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentN =1;
            bool isBigger = false;

            for (int rows = 1; rows <=n ; rows++)
            {
                for (int i = 1; i <=rows; i++)
                { 
                  if (currentN >  n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(currentN + " ");
                    currentN++;
                }


                if (isBigger)
                {
                    break;
                }

                Console.WriteLine();
            }


        }
    }
}
