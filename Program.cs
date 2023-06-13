
using System;

public class SayHi
{
    public static void PrintGreeting(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
    public static void findSum(int a,int b)
    {
        Console.WriteLine(a+b);
    }
}

public class Program
{    public static void Main(string[] args)
    {
        // Prompt the user for their name
        Console.Write("Enter your name: ");
        string? name = "";
        name = Console.ReadLine();
        // Prompt the user for their name
        Console.Write("Enter the first number:");
        int a = 1;
        int b = 2;
        string? input = Console.ReadLine();
        int parsedValue;

        if (int.TryParse(input, out parsedValue))
        {
            b = parsedValue;
        }
        else
        {
            // Handle the case where the input cannot be parsed to an int
        }

        // Print a greeting with the user's name
        Console.WriteLine($"Hello, {name}!");
        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(); // Replace with the desired name
        if (name != null)
        {
            SayHi.PrintGreeting(name);
        }
        SayHi.findSum(a, b);
        if (b % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else{
            Console.WriteLine("odd");
        }
}
}

