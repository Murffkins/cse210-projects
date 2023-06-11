using System;

public class ReflectingActivity : Activity
{
  private List<string> _reflectionPrompts = new List<string> {
    " --- Think of a time when you did something really difficult. ---",
    " --- Think of a time when you worked hard for something you wanted. ---",
    " --- Think of a time when you stood up for something you believed in. ---",
    " --- Think of a time when you went out of your way to make someone smile. ---",
    " --- Think of a time when you helped someone in need. ---"
  };

  private List<string> _questions = new List<string> {
    "What is your favorite thing about this experience?",
    "What did you learn about yourself from this experience?",
    "How was this experience different from others like it?",
    "How can you keep this experience in mind in the future?",
    "How did you feel when it was complete?",
    "Why was this experience meaningful to you?",
    "How has this experience changed your thoughts/feelings/actions?"
  };
  
  
  public ReflectingActivity() : base("Reflecting")
  {

  }

  public override void GetDescription()
  {
    Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. " + System.Environment.NewLine + 
    "This will help you recognize the power you have and how you can use it in other aspects of your life.");
  }

    public void GetQuestions()
    {
        Random r = new Random();
        int i = r.Next(_questions.Count());
        Console.WriteLine(_questions[i]);
    }

    public void GetInstruction()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experince.");
        Console.Write("You may begin in: ");
        GetAnimationCountdown(5);
    } 

    public void GetReflectionPrompt()
    {
        Random r = new Random();
        int i = r.Next(_reflectionPrompts.Count());
        Console.WriteLine(_reflectionPrompts[i]);
    }


    public override void RunActivity()
    {

        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        GetReflectionPrompt();

        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");

        // Exceeds requirements -- makes sure that the user specifically presses the Enter key
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        {
          Console.WriteLine("Press the Enter key to continue.");
        }
        Console.WriteLine();

        Console.Clear();
        GetInstruction();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            GetQuestions();
            Thread.Sleep(5000);
        }
        Console.WriteLine();

    }

}