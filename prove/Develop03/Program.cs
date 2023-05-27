using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Word word = new Word();

        // Console.WriteLine("Hello Develop03 World!");
        string response = string.Empty;
        while (!response.Equals("quit"))
        {
            // Call the method to display a random scripture to the user
            string random_scripture = scripture.GetRenderedText();
            Console.WriteLine(random_scripture);
            Console.WriteLine();

            scripture.HideWords();

            Console.ReadLine();
        }
        
        Console.WriteLine();

        // Display action prompt to the user
        Console.WriteLine("Press ENTER to continue or type 'quit' to finish:");
        Console.ReadLine();

        // If user presses the ENTER key, call the method to hide random words in the verse
        word.Hide();

        // If user types 'quit', exit the program
    }
}