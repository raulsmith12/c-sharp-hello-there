using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Unit Converter ===");
            Console.WriteLine("1. Length (km <-> miles)");
            Console.WriteLine("2. Temperature (C <-> F)");
            Console.WriteLine("3. Weight (kg <-> lbs)");
            Console.WriteLine("4. Exit");
            Console.Write("\nChoose an option: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Try again.");
                Console.ReadKey();
                continue;
            }

            switch (choice)
            {
                case 1:
                    ConvertLength();
                    break;
                case 2:
                    ConvertTemperature();
                    break;
                case 3:
                    ConvertWeight();
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void ConvertLength()
    {
        Console.Write("Enter value: ");
        double value = Convert.ToDouble(Console.ReadLine());
        Console.Write("Convert (1) km → miles or (2) miles → km? ");
        int option = Convert.ToInt32(Console.ReadLine());

        double result = option == 1 ? value * 0.621371 : value / 0.621371;
        Console.WriteLine($"Result: {Math.Round(result, 3)}");
    }

    static void ConvertTemperature()
    {
        Console.Write("Enter value: ");
        double value = Convert.ToDouble(Console.ReadLine());
        Console.Write("Convert (1) C → F or (2) F → C? ");
        int option = Convert.ToInt32(Console.ReadLine());

        double result = option == 1 ? (value * 9 / 5) + 32 : (value - 32) * 5 / 9;
        Console.WriteLine($"Result: {Math.Round(result, 2)}");
    }

    static void ConvertWeight()
    {
        Console.Write("Enter value: ");
        double value = Convert.ToDouble(Console.ReadLine());
        Console.Write("Convert (1) kg → lbs or (2) lbs → kg? ");
        int option = Convert.ToInt32(Console.ReadLine());

        double result = option == 1 ? value * 2.20462 : value / 2.20462;
        Console.WriteLine($"Result: {Math.Round(result, 3)}");
    }
}
