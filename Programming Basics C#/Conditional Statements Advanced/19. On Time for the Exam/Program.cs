using System;

namespace _08.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            int examTime = examHour*60 + examMin;
            int arriveTime = arriveHour*60 + arriveMin;

            int difference = 0;
            int diffHour = 0;
            int diffMin = 0;



            if (examTime < arriveTime)
            {
                Console.WriteLine("Late");
                difference = arriveTime - examTime;
                diffHour = difference / 60;
                diffMin = difference % 60;

                if (diffHour >= 1)
                {
                    if (diffMin < 10)
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours after the start");
                    }


                    else
                    {
                        Console.WriteLine($"{diffHour}:{diffMin} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes after the start");
                }
            }
            else if (examTime - arriveTime <= 30)
            {

                Console.WriteLine("On time");
                if (examMin != arriveMin)

                {
                    difference = examTime - arriveTime;
                    
                    diffMin = difference % 60;

                 

                    Console.WriteLine($"{diffMin} minutes before the start");
                }
                
                
            }

            else
            {
                Console.WriteLine("Early");
                difference = examTime - arriveTime;
                diffHour = difference / 60;
                diffMin = difference % 60;
                 
                if (diffHour >= 1)
                {
                    if (diffMin < 10)
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours before the start");
                    }


                    else
                    {
                        Console.WriteLine($"{diffHour}:{diffMin} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes before the start");
                }

            }
        
        }


        }
        
        }


