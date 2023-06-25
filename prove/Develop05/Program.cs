using System;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;

        string userMenuChoice = string.Empty;
        GoalManager goalManager = new GoalManager();

        while (!userMenuChoice.Equals("6"))
        {
            Console.WriteLine("Menu Options:" + System.Environment.NewLine + "  1. Create New Goal" + System.Environment.NewLine +
            "  2. List Goals" + System.Environment.NewLine + "  3. Save Goals" + System.Environment.NewLine + "  4. Load Goals"
            + System.Environment.NewLine + "  5. Record Event" + System.Environment.NewLine + "  6. Quit");

            Console.Write("Select a choice from the menu: ");
            userMenuChoice = Console.ReadLine();

            switch (userMenuChoice)
            {
                case "1":
                    {
                        string userMenuChoice2 = string.Empty;

                        Console.WriteLine("The type of goals are:" + System.Environment.NewLine + "  1. Simple Goal" + System.Environment.NewLine +
                        "  2. Eternal Goal" + System.Environment.NewLine + "  3. Checklist Goal");

                        Console.Write("Which type of goal would you like to create? ");
                        userMenuChoice2 = Console.ReadLine();

                        Console.Write("What is the name of your goal? ");
                        string userGoalName = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        string userGoalDescription = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        string userGoalPoints = Console.ReadLine();


                        switch (userMenuChoice2)
                        {
                            case "1":
                                {
                                    Goal simple = new SimpleGoal();
                                    simple.SetGoalInfo(userGoalName, userGoalDescription, Int32.Parse(userGoalPoints));
                                    goalManager.AddGoal(simple);
                                    break;
                                }

                            case "2":
                                {
                                    Goal eternal = new EternalGoal();
                                    eternal.SetGoalInfo(userGoalName, userGoalDescription, Int32.Parse(userGoalPoints));
                                    goalManager.AddGoal(eternal);
                                    break;
                                }

                            case "3":
                                {
                                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                    string _maxComplete = Console.ReadLine();

                                    Console.Write("What is the bonus amount for accomplishing it that many times? ");
                                    string _bonusPoints = Console.ReadLine();

                                    Goal checklist = new ChecklistGoal();
                                    checklist.SetGoalInfo(userGoalName, userGoalDescription, Int32.Parse(userGoalPoints), Int32.Parse(_maxComplete), Int32.Parse(_bonusPoints));
                                    goalManager.AddGoal(checklist);
                                    break;
                                }
                        }


                        break;
                    }

                case "2":
                    {
                        Console.WriteLine();
                        Console.WriteLine("The goals are:");
                        goalManager.ListGoals();
                        Console.WriteLine();
                        break;
                    }

                case "3":
                    {
                        Console.Write("What is the filename? ");
                        string fileName = Console.ReadLine();

                        // Stream opens a connection to a file. You can then read or write to a file.
                        using (StreamWriter outputFile = new StreamWriter(fileName))
                        {
                            outputFile.Write(goalManager.GetGoals());
                        }
                        break;
                    }

                case "4":
                    {
                        Console.Write("What is the filename? ");
                        string fileName = Console.ReadLine();

                        using (StreamReader inputFile = new StreamReader(fileName))
                        {
                            goalManager = new GoalManager();
                            var points = inputFile.ReadLine();
                            goalManager.AddPoints(Int32.Parse(points));

                            while (!inputFile.EndOfStream)
                            {
                                var goalText = inputFile.ReadLine();

                                var splitGoal = goalText.Split("!@#$");

                                var type = splitGoal[0];
                                var name = splitGoal[1];
                                var description = splitGoal[2];
                                var point = splitGoal[3];
                                var bonusPoints = splitGoal[4];
                                var complete = splitGoal[5];
                                var maxComplete = splitGoal[6];
                                var currentComplete = splitGoal[7];

                                Goal goal = null;

                                if (type.Equals("SimpleGoal"))
                                {
                                    goal = new SimpleGoal();
                                    goal.SetGoalInfo(name, description, Int32.Parse(point));
                                    if (bool.Parse(complete))
                                    {
                                        goal.SetComplete();
                                    }
                                }
                                else if (type.Equals("EternalGoal"))
                                {
                                    goal = new EternalGoal();
                                    goal.SetGoalInfo(name, description, Int32.Parse(point));
                                }
                                else if (type.Equals("ChecklistGoal"))
                                {
                                    goal = new ChecklistGoal();
                                    goal.SetGoalInfo(name, description, Int32.Parse(point), Int32.Parse(maxComplete), Int32.Parse(bonusPoints));
                                    goal.SetCurrentComplete(Int32.Parse(currentComplete));
                                }

                                goalManager.AddGoal(goal);
                            }
                        }
                        break;
                    }

                case "5":
                    {
                        Console.WriteLine("The goals are:");
                        goalManager.ListGoalNames();
                        Console.Write("Which goal did you accomplish? ");
                        string recordChoice = Console.ReadLine();
                        Goal goal = goalManager.GetGoal(Int32.Parse(recordChoice));
                        int points = goal.RecordEvent();
                        goalManager.AddPoints(points);

                        Console.WriteLine($"Congratulations! You have earned {points} points!");
                        Console.WriteLine($"You now have {goalManager.GetScore()} points");
                        break;
                    }

                case "6":
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
}