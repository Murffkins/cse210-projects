using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int userNum = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNum != 0)
        {
            Console.Write("Enter a number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
            
        }

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        int minNum = 1;
        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     if (numbers[i] < minNum && numbers[i] > 0)
        //     {
        //         minNum = numbers[i];
        //     }
        // }
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                minNum = numbers.Min();
            }
            
        }
        Console.WriteLine($"The smallest positive number is: {minNum}");
        
    }
}