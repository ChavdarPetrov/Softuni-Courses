using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a:f3}");
            }

            else if (figure == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine($"{b * c:f3}");

            }

            else if (figure == "circle")
            {
                double d = double.Parse(Console.ReadLine());

                Console.WriteLine($"{2*d * 2*d * Math.PI / 4:f3}");
           
            }
        

            else if (figure == "triangle")
            {
                double e = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"{e * h / 2:f3}");

            }
        }

}
}


