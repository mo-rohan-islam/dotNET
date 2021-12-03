using Humanizer;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program {
    static void Main(string[] args) {

        Snippet1();
        // Snippet2();          // Incomplete function Fibonacci(x)
    }

/*    static void Snippet2() {
        int result = Fibonacci(5);
        Console.WriteLine(result);
        Console.ReadKey(true);
    }

    static int Fibonacci(int n) {
        int n1 = 0;
        int n2 = 1;
        int sum = 0;

        for (int i = 2; i < n; i++) {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
        }

        return 
    }
*/
    static void Snippet1()
    {
        Console.WriteLine("Quantities:");
        HumanizeQuantities();

        Console.WriteLine("\nDate/Time Manipulation:");
        HumanizeDates();
    }

    static void HumanizeQuantities()
    {
        Console.WriteLine("case".ToQuantity(0));
        Console.WriteLine("case".ToQuantity(1));
        Console.WriteLine("case".ToQuantity(5));
    }

    static void HumanizeDates()
    {
        Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
        Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
        Console.WriteLine(TimeSpan.FromDays(1).Humanize());
        Console.WriteLine(TimeSpan.FromDays(16).Humanize());
    }
}