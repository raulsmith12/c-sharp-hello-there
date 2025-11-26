using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Grade Evaluator ===");
        Console.Write("Enter your numeric grade (0-100): ");

        double grade;
        while (!double.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
        {
            Console.Write("Invalid input. Please enter a number between 0 and 100: ");
        }

        string letterGrade = GetLetterGrade(grade);
        Console.WriteLine($"\nYour grade: {letterGrade}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static string GetLetterGrade(double grade)
    {
        if (grade >= 90)
            return "A";
        else if (grade >= 80)
            return "B";
        else if (grade >= 70)
            return "C";
        else if (grade >= 60)
            return "D";
        else
            return "F";
    }
}
