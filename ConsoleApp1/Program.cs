using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            IfStatement();
        }

        static void IfStatement()
        {
            var num1 = 5;
            var num2 = 6;

            var expression = num1 + num2 > 10;
            if (expression)
                Console.WriteLine("Expression is True!");

            var num3 = 4;

            if ((num1 + num2 + num3 > 10) && (num1 > num2))
            {
                Console.Write($"{num1} + {num2} + {num3} > 10");
                Console.WriteLine($"\t\t&& {num1} > {num2}");
            }
            else
            {
                Console.WriteLine("Either or Both conditions don't satisfy.");
            }

            if (
                    (num1 + num2 + num3 > 5)

                    ||

                    (num1 > num2)
               )

            {
                Console.Write($"{num1} + {num2} + {num3} > 5");
                Console.WriteLine($"\t\tAND/OR\t\t{num1} > {num2}");
            }
            else
            {
                Console.WriteLine("None of the conditions satisfy.");
            }
        }
    }
}
