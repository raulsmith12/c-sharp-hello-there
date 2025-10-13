using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        Console.Write("Who are you? ");
        string name = Console.ReadLine();

        Console.Write("How old are you? ");
        string age = Console.ReadLine();

        Console.WriteLine($"Hello, {name}, you are {age} years old!");
    }
}