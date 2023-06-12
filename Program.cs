// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
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
{
    public static void Main(string[] args)
    {
        string name = "John"; // Replace with the desired name
        int a = 1;
        int b = 2;
        SayHi.PrintGreeting(name);
        SayHi.findSum(a, b);
    }
}

