using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        // Grade calculator
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int gradeNum = int.Parse(percentage);

        string letterGrade = "";

        if (gradeNum >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeNum >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeNum >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeNum >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (gradeNum >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else 
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}