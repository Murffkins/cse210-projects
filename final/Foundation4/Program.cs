using System;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("");

        Activity running = new Running("03 Nov 2022", 60, 5);
        Console.WriteLine(running.GetSummary());

        Activity swimming = new Swimming("03 Nov 2022", 60, 50);
        Console.WriteLine(swimming.GetSummary());

        Activity cycling = new Cycling("03 Nov 2022", 120, 5);
        Console.WriteLine(cycling.GetSummary());

        Console.WriteLine("");
    }
}