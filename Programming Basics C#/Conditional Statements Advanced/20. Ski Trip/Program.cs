using System;

namespace _09.Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rate = Console.ReadLine();

            int nights = days - 1;
            double priceRoom = 18;
            double priceApp = 25;
            double pricePrApp = 35;
            double totalPrice = 0;

            switch (room)
            {
                case "room for one person":
                    totalPrice = nights * priceRoom;
                    break;

                case "apartment":
                    if (nights < 10)
                    {
                        totalPrice = (1-0.3) * nights * priceApp; 
                    }

                    else if (nights <= 15)
                    {
                        totalPrice = (1-0.35)*nights* priceApp;
                    }

                    else
                    {
                        totalPrice = (1-0.5) * nights * priceApp;
                    }
                    break;


                case "president apartment":
                    if (nights < 10)
                    {
                        totalPrice = (1-0.1) * nights * pricePrApp;
                    }

                    else if (nights <= 15)
                    {
                        totalPrice = (1-0.15) * nights * pricePrApp;
                    }

                    else
                    {
                        totalPrice = (1-0.2) * nights * pricePrApp;
                    }
                    break;


            }

            if (rate == "positive")
            {
                totalPrice = (1+0.25) * totalPrice;
            }
            else 
            {
                totalPrice = (1-0.1) * totalPrice;
            }


            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
