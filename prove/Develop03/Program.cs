using System;

class Program
{
    static void Main(string[] args)
    {
        // Create scripture reference
        Reference reference = new Reference();
        string new_reference = reference.DisplayText();

        Scripture scripture = new Scripture();
        Console.WriteLine(scripture.GetRenderedText());

        string response = string.Empty;

        // Program keeps running unless either the user types 'quit' or there are no more words to hide
        while (!response.Equals("quit"))
        {
            Console.Clear();

            if (scripture.IsCompletelyHidden()) {
                break;
            }

            
            Console.WriteLine(scripture.GetRenderedText());
            scripture.HideWords();

            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue or type 'quit' to finish:");
            response = Console.ReadLine();
        }
        
        Console.WriteLine();
    }
}