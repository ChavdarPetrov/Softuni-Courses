using System;

namespace _11.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string item = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double price = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":

                     if  (item == "banana")
                    {
                        price = 2.5;
                    }

                    else if (item == "apple")
                    {
                        price = 1.2;
                    }
                    else if(item == "orange")
                    {
                        price = 0.85;
                    }
                    else if(item == "grapefruit")
                    {
                        price = 1.45;
                    }

                    else if(item == "kiwi")
                    {
                        price = 2.7;
                    }

                    else if(item == "pineapple")
                    {
                        price = 5.5;
                    }

                    else if(item == "grapes")
                    {
                        price = 3.85;
                    }

                    else
                    {

                        Console.WriteLine("error");

                    }
                    break;

                case "Saturday":
                case "Sunday":

                    if (item == "banana")
                    {
                        price = 2.7;
                    }

                    else if(item == "apple")
                    {
                        price = 1.25;
                    }
                    else if(item == "orange")
                    {
                        price = 0.9;
                    }
                    else if(item == "grapefruit")
                    {
                        price = 1.6;
                    }

                    else if(item == "kiwi")
                    {
                        price = 3;
                    }

                    else if(item == "pineapple")
                    {
                        price = 5.6;
                    }

                    else if(item == "grapes")
                    {
                        price = 4.2;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

            double total = amount * price;

            if (total != 0)
            {
                Console.WriteLine($"{total:f2}");

            }
        }
    }
}