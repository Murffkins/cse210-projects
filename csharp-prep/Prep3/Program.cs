using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Ask user for magic number
        // Console.Write("What is the magic number? ");
        // int userMagicNum = int.Parse(Console.ReadLine());

        Random randomGenerator= new Random();
        int magicNum = randomGenerator.Next(1, 101);

        // Prompt user to guess magic number
        int userGuessNum = -1;
        int attempts = 0;

        while (userGuessNum != magicNum)
        {
            Console.Write("What is your guess? ");
            userGuessNum = int.Parse(Console.ReadLine());
        

            if (userGuessNum < magicNum)
            {
                Console.WriteLine("Higher");
                attempts += 1;
            }
            else if (userGuessNum > magicNum)
            {
                Console.WriteLine("Lower");
                attempts += 1;
            }
            else 
            {
                attempts += 1;
                Console.WriteLine($"You guessed it in {attempts} attempts!");
            }
        }

        

        // Ask if user wants to play again

        // If 'yes', loop back and play again until user says 'no'       

    }
}