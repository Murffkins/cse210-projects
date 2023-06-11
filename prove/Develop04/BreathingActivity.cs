using System;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing")
    {
        
    }

    public override void GetDescription()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly." + System.Environment.NewLine + 
        "Clear your mind and focus on your breathing.");
    }

    public void GetInstruction()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            GetBreatheInMessage();
            GetBreatheOutMessage();
        }
        
    }

    public void GetBreatheInMessage()
    {
        // Repeat this for the duration of the activity
        Console.Write("Breathe in...");
        GetAnimationCountdown(4); 
        Console.WriteLine();

    }

    public void GetBreatheOutMessage()
    {
        // Repeat this for the duration of the activity
        Console.Write("Now breathe out...");
        GetAnimationCountdown(4);
        Console.WriteLine();
    }

    public override void RunActivity()
    {
       GetInstruction();
    }

}