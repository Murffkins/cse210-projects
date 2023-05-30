using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment object
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        // Math Assignment object
        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine();

        // Writing Assingment object
        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of War II");
        
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
        Console.WriteLine();
    }
}