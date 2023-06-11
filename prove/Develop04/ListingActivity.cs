using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{    
    private List<string> _userResponseList = new List<string>();

    private List<string> _listingPrompt = new List<string> {
        " --- Who are people that you appreciate? ---",
        " --- What are personal strengths of yours? ---",
        " --- Who are people you have helped this week? ---",
        " --- When have you felt the Holy Ghost this month? ---",
        " --- Who are some of your personal heroes? ---"
    };
    
    public ListingActivity() : base("Listing")
    {

    }

    public override void GetDescription()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void GetPrompt()
    {
        Random r = new Random();
        int i = r.Next(_listingPrompt.Count());
        Console.WriteLine(_listingPrompt[i]);
    }

    public void StoreResponse()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            string _userResponse = Console.ReadLine();
            _userResponseList.Add(_userResponse);
        }
        Console.WriteLine($"You listed {_userResponseList.Count} items!");
    }

    public override void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetPrompt();
        Console.WriteLine();
        Console.Write("You may begin in: ");
        GetAnimationCountdown(5);
        Console.WriteLine();
        StoreResponse();
    }

 
}