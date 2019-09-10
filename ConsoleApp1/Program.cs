using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years experience do you have in professional programming?");
            string input = Console.ReadLine();
            int yrs_of_exp = int.Parse(input);
            switch (yrs_of_exp)
            {
                case 0:
                    Console.WriteLine("You need a lot of practice");
                    Console.ReadKey(true);
                    break;
                case 1:
                    Console.WriteLine("You look like you have a little experience");
                    Console.ReadKey(true);
                    break;
                case 2:
                    Console.WriteLine("Wow! You've been doing this for a long time");
                    Console.ReadKey(true);
                    break;
                default:
                    Console.WriteLine("You are an expert!");
                    Console.ReadKey(true);
                    break;
            }


             
                       
        }
    }
}
