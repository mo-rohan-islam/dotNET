using System;

namespace MyApp
{
    /* public */ class Program
    {
        /* public */ static void Main(String[] args)
        {
            // Snippet1();

            Snippet2();            
        }

        static void Snippet2()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            var now = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello {name}! on {now:d} at {now:t}!");
            Console.WriteLine($"{Environment.NewLine}Press any key to continue...");
            Console.ReadKey();
        }

        static void Snippet1()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            Console.WriteLine("The current time is " + DateTime.Now);
        }
    }
}
