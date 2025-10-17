using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Simple Calculator ===");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nChoose an operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("\nEnter choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                break;
            case 2:
                result = Subtract(num1, num2);
                break;
            case 3:
                result = Multiply(num1, num2);
                break;
            case 4:
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine($"\nResult: {result}");
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
            return 0;
        }
        return Math.Round(a / b, 5);
    }
}
