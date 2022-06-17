using System;

namespace Vacation_Book_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hoursPerDay = bookPages / pagesPerHour / days;

            Console.WriteLine( hoursPerDay );
        }
    }
}
