using Humanizer;
using System.Diagnostics;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        // MainSnippet1();
        DotNetDebugging2();
        // LogAndTrace3();
    }

    static void LogAndTrace3()
    {
        Console.WriteLine("This message is readable by the end user.");
        Trace.WriteLine("This is a trace message when tracing the app.");
        Debug.WriteLine("This is a debug message just for developers.");

        Debug.Write("Debug - ");
        Debug.WriteLine("This is a full line.");
        Debug.WriteLine("This is another full line.");

        int count = 0;
        if (count == 0)
        {
            Debug.WriteLine("The count is 0 and this may cause an exception.");
        }
        Debug.WriteLineIf(count == 0, "The count is 0 and this may cause an exception.");

        bool errorFlag = false;
        System.Diagnostics.Trace.WriteIf(errorFlag, "Error in AppendData procedure.");
        errorFlag = true;
        System.Diagnostics.Debug.WriteIf(errorFlag, "Transaction abandoned.");
        System.Diagnostics.Trace.Write("Invalid value for data request");

        Program ps = new Program();
        Console.WriteLine("Quotient: " + ps.IntegerDivide(6, 0));
        Console.WriteLine("Quotient: " + ps.IntegerDivide(6, 2));
    }

    int IntegerDivide(int dividend, int divisor)
    {
        Debug.Assert(divisor != 0, $"{nameof(divisor)} is 0 and will cause an exception.");

        return dividend / divisor;
    }

    static void DotNetDebugging2()
    {
        int result = Fibonacci(6);
        Console.WriteLine(result);
        Console.ReadKey(true);
    }

    static int Fibonacci(int n)
    {
        Debug.WriteLine($"Entering {nameof(Fibonacci)} method.");
        Debug.WriteLine($"We are looking for the {n.Ordinalize()} number");

        int n1 = 0;
        int n2 = 1;
        int sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
            Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
        }

        // If n2 is 5 continue, else break.
        Debug.Assert(n2 == 5, $"The return value is {n2} but it should be 5.");
        return n == 0 ? n1 : n2;
    }

    static void MainSnippet1()
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