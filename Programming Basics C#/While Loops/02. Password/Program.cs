using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {

            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string passwordAttempt = "";
            while (passwordAttempt != password)
            {
                passwordAttempt = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
