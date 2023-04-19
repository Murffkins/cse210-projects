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
        int gradeSign = gradeNum % (10);

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

        // Add +/- to grade letter
        if (gradeSign >= 7 && gradeNum < 90 && gradeNum > 60)
        {
            letterGrade += "+";
        }
        else if (gradeSign < 3 && gradeNum >= 60)
        {
            letterGrade += "-";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        // Passed the class if >= 70
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