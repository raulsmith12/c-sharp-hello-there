using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade (0-100): ");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade >= 90)
            Console.WriteLine("A");
        else if (grade >= 80)
            Console.WriteLine("B");
        else if (grade >= 70)
            Console.WriteLine("C");
        else if (grade >= 60)
            Console.WriteLine("D");
        else
            Console.WriteLine("F");

        Console.Write("Enter a number (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You chose Option 1");
                break;
            case 2:
                Console.WriteLine("You chose Option 2");
                break;
            case 3:
                Console.WriteLine("You chose Option 3");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Count: {i}");
        }

        int counter = 1;
        while (counter <= 5)
        {
            Console.WriteLine($"While Count: {counter}");
            counter++;
        }

        int number;
        do
        {
            Console.Write("Enter a number (0 to quit): ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {number}");
        } while (number != 0);

        string[] fruits = { "Apple", "Banana", "Cherry" };

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.Write("Enter a number for its multiplication table: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nMultiplication Table for {num}");

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}
