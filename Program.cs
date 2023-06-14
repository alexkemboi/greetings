
using System;

public class SayHi
{
    public static void PrintGreeting(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
    public static void findSum(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left <= right)
        {
            int mid = (left + (right - left)) / 2;
            if (array[mid] == target)
                return mid;
            if (array[mid] > target)
                right = mid - 1;
            if (array[mid] < target)
                left = mid + 1;
        }
        return -1;
    }
    public static void findNumberType(int b){
          if (b % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else{
            Console.WriteLine("odd");
        }
    }
}

public class Program
{    public static void Main(string[] args)
    {
        int[] array = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
        int target = 3;
        int index = SayHi.BinarySearch(array, target);
        Console.WriteLine($"the element {target} is located at index {index}");
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
        if (name != null)
        {
            SayHi.PrintGreeting(name);
        }
        SayHi.findSum(a, b);
        SayHi.findNumberType(b);
        Console.WriteLine($"Hello, {name}!");
        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(); // Replace with the desired name
    }
}

