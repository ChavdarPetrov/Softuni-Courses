using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int counter = 0;
            string currentBook = Console.ReadLine();

            while (currentBook != "No More Books")
            {

                if (currentBook==favBook)
                {
                    break;
                }

                counter++;
               currentBook = Console.ReadLine();
            }

            if (currentBook == favBook)
            {

               Console.WriteLine($"You checked {counter} books and found it.");
            }


            else  { 
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
