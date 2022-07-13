using System;

namespace _07.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());


            double priceSt = 0;
            double priceApp = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceSt = 50;
                    priceApp = 65;

                    if (nights > 7 && nights<=14)
                    {
                        priceSt -=0.05*priceSt;
                    }
                    else if (nights > 14)
                    {
                        priceSt -= 0.30 * priceSt;
                    }
                    break;



                case "June":
                case "September":
                    priceSt = 75.2;
                    priceApp = 68.7;
                    if (nights > 14)
                    {
                        priceSt -= 0.2 * priceSt;
                    }
                    break;

                case "July":
                case "August":
                    priceSt = 76;
                    priceApp = 77;
                    break;


            }

            if (nights > 14)
            {
                priceApp -= 0.1 * priceApp;
            }

            Console.WriteLine($"Apartment: {nights*priceApp:f2} lv.");
            Console.WriteLine($"Studio: {nights*priceSt:f2} lv.");


        }
    }
}
