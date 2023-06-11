using System;

// Exceeding Requirements:
// In the ReflectingActivity class, I wrote code to make sure that the user specifically presses the Enter key.
// In the Activity class, I wrote code to make sure that the user inputs a positive number for their chosen activity duration.

class Program
{
    static void Main(string[] args)
    {
        string userMenuChoice = string.Empty;

        while (!userMenuChoice.Equals("4"))
        {
            Console.WriteLine("Menu Options:" + System.Environment.NewLine + "  1. Start Breathing activity" + System.Environment.NewLine + 
            "  2. Start reflecting activity" + System.Environment.NewLine + "  3. Start listing activity" + System.Environment.NewLine + "  4. Quit");

            Console.Write("Select a choice from the menu: ");
            userMenuChoice = Console.ReadLine();

            switch(userMenuChoice)
            {
                case "1":
                {
                    Activity activity = new BreathingActivity();
                    RunActivity(activity);
                    break;
                }
                
                case "2":
                {
                    Activity activity = new ReflectingActivity();
                    RunActivity(activity);
                    break;
                }

                case "3":
                {
                    Activity activity = new ListingActivity();
                    RunActivity(activity);
                    break;
                }

                case "4":
                {
                    break;
                }

                default:
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }
            }
        }
    }

    private static void RunActivity(Activity activity)
    {
        activity.GetWelcomeMessage();
        Console.WriteLine();
        activity.GetDescription();
        Console.WriteLine();
        activity.GetDuration();
        Console.WriteLine();
        activity.GetReadyMessage();
        Console.WriteLine();
        activity.RunActivity();
        Console.WriteLine();
        activity.GetEndingMessage();
        Thread.Sleep(5000);
        Console.WriteLine();

    }
}