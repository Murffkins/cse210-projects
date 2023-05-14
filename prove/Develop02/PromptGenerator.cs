static class PromptGenerator
{
    public static string getPrompt()
    {
        Random random = new Random();
        int num = random.Next(1, 5);

        switch (num)
        {
            case 1:
            {
                return "Who was the most interesting person I interacted with today?";
            }

            case 2:
            {
                return "What was the best part of my day?";
            }
            
            case 3:
            {
                return "How did I see the hand of the Lord in my life today?";
            }
            
            case 4:
            {
                return "What was the strongest emotion I felt today?";
            }
            
            case 5:
            {
                return "If I had one thing I could do over today, what would it be?";
            }
            
            default:
            {
                return "What was the coolest color you saw today?";
            }

        }

    }
}