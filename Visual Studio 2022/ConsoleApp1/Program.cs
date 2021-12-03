using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<string> names = new List<string> { "<name>", "Rohan", "Khushboo" };

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // IfStatement();

            ListTutorial();
        }

        static void ListTutorial()
        {
            // var names = new List<string> { "<name>", "Rohan", "Khushboo" };

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name/*.ToUpper()*/}!");
            }

            names.Add("Inamul");
            names.Add($"Deleting {names[0]}...");
            names.Remove("<name>");
            names.Insert(0, "=================");

            for (int i = 0; i < names.Count; i++)
                Console.WriteLine($"Hello {names[i]/*.ToUpper()*/}!");

            var deleteName = names[names.Count - 1];
            var index = names.IndexOf(deleteName);
            Console.WriteLine($"Found \"{deleteName}\" at {index}");
            names.Remove(deleteName);
            Console.WriteLine($"\"{deleteName}\" deleted!");

            Console.WriteLine($"{Environment.NewLine}Converting List to UpperCase...");
            //foreach (var name in names)
            //{
            //    name = name.ToUpper();
            //    Console.WriteLine(name);
            //}
            for (var i = 0; i < names.Count; i++)
            {
                names[i] = names[i].ToUpper();
                Console.WriteLine(names[i]);
            }

            var flag = true;
            while (flag == true)
            {
                Console.WriteLine("Press 1 to search and any other key to exit...\n");
                // var choice = Int32.Parse(Console.ReadLine());
                switch (Console.ReadLine())        // Will not give exception integer input
                {
                    case "1":
                        SearchInput();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }

            names.Sort();
            Console.WriteLine("\nAfter sorting...");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void SearchInput()
        {
            Console.Write($"{Environment.NewLine}Which name do you want to search? ");
            var search = Console.ReadLine();
            if (!FindName(search))
            {
                search = search.ToUpper();
                Console.WriteLine("Adding " + search + "...");
                names.Add(search);
                FindName(search);
            }
            else
            {
                Console.WriteLine("FindName() returned true." +
                    "\n" +
                    "Current List..." +
                    "");
                for (int i = 0; i < names.Count; i++)
                    Console.WriteLine($"{i}. {names[i]}");
            }
        }

        static bool FindName(string name)
        {
            // var name = "Avanti";

            var index = names.IndexOf(name.ToUpper());
            if (index != -1)
            {
                Console.WriteLine($"{names[index]} Found at index {index}!");
                return true;
            }
            else
            {
                Console.WriteLine($"{name.ToUpper()} NOT Found!");
                return false;
            }
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