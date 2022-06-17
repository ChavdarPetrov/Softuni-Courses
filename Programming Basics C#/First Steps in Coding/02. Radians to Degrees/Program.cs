using System;

namespace My_first
{
    class Program
    {
        static void Main(string[] args)
        {


            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180/ Math.PI;

            Console.WriteLine(degrees);




        }


    }
}
