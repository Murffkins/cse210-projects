using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

// Declare a new list
        List<int> numbers = new List<int>();
        int userNum = -1;

// Get user input
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

// Add user input to the list
        while (userNum != 0)
        {
            Console.Write("Enter a number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
            
        }

// Calculate and print the sum of all of the numbers in the list
        Console.WriteLine($"The sum is: {numbers.Sum()}");

// Calculate and print the average of the numbers
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

// Find and print the largest number in the list
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

// Find and print the smallest positive number in the list
        int minNum = int.MaxValue;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < minNum && numbers[i] > 0)
            {
                minNum = numbers[i];
            }
        }

        Console.WriteLine($"The smallest positive number is: {minNum}");

// Sort and print the numbers in the list
        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        
    }
}