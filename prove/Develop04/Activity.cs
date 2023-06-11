using System;

public abstract class Activity
{
    private string _activityName = "";
    protected int _duration = 0;

    public Activity()
    {

    }

    public Activity(string activityName)
    {
        // Setters
        _activityName = activityName;
        
    }
    
    public void GetWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        // write logic to figure out which activity
    }
    private void GetAnimation(int duration)
    {
        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    protected void GetAnimationCountdown(int countdown)
    {
        for (int i = countdown; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void GetDuration()
    {
        bool validNumber = false;
        while(!validNumber) {
            Console.Write("How long, in seconds, would you like for your session? ");
            string seconds = Console.ReadLine();

            if (Int32.TryParse(seconds, out int duration))
            {
                // Exceeding Requirements -- makes sure that the user inputs a positive number
                if (duration > 0)
                {
                    validNumber = true;
                    _duration = duration;
                }
                else 
                {
                    Console.WriteLine("Invalid number. Please enter a positive number.");
                }
                
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }

    public void GetEndingMessage()
    {
        Console.WriteLine("Well done!!");
        GetAnimation(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
    }
    public void GetReadyMessage()
    {
        Console.WriteLine("Get ready...");
        GetAnimation(3);
    }
    public abstract void GetDescription();
    
    public abstract void RunActivity();
    
}