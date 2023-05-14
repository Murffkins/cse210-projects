using System;
// dotnet add package CsvHelper

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        string actionChoice = "";
        Journal journal = new Journal();

        while (actionChoice != "5")
        {            
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            actionChoice = Console.ReadLine();

            switch (actionChoice)
            {
                case "1":
                {
                    // stretch challenge addition
                    Console.WriteLine("Enter journal entry title: ");
                    string title = Console.ReadLine();
                    string prompt = PromptGenerator.getPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    // stretch challenge addition
                    Console.WriteLine("Enter author name: ");
                    string author = Console.ReadLine();
                    
                    // stretch challenge addition
                    Entry entry = new Entry(title, prompt, response, author);
                    journal.entries.Add(entry);
                    break;
                }
                case "2":
                {
                    Console.WriteLine(journal.ToString());
                    
                    break;
                }
                case "3":
                {     
                    Console.Write("What is the filename?");
                    string fileName = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    int counter = 0;
                    string date = "";
                    // stretch challenge addition
                    string title = "";
                    string prompt= "";
                    string answer = "";
                    // stretch challenge addition
                    string author = "";
                    journal = new Journal();

                    foreach (string line in lines)
                    {
                        counter++;
                        if (counter == 1)
                        {
                            date = line;
                        }
                        else if (counter == 2)
                        {
                           // stretch challenge addition
                           string[] splitLine = line.Split("Title: ");
                            title = splitLine[1];
                        }
                        else if (counter == 3)
                        {
                            prompt = line;
                        }
                        else if (counter == 4)
                        {
                            answer = line;
                        }
                        else if (counter == 5)
                        {
                            // stretch challenge addition
                            string[] splitLine = line.Split("Author: ");
                            author = splitLine[1];
                            // loads entries into journal
                            Entry entry = new Entry(date, title, prompt, answer, author);
                            journal.entries.Add(entry);
                            counter = 0;
                        }
                    }
                    break;
                }
                case "4":
                {
                    Console.Write("What is the filename?");
                    string fileName = Console.ReadLine();

                    // Stream opens a connection to a file. You can then read or write to a file.
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                       outputFile.Write(journal.ToString()); 
                        
                    }
                    break;
                }
                case "5": 
                {
                    break;
                }
                default:
                {
                    Console.WriteLine("That is an invalid choice. Please try again.");
                    break;
                }
            }
        }

    }
}