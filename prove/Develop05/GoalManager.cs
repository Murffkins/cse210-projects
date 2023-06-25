using System;
using System.Text;

public class GoalManager
{
    private List<KeyValuePair<int, Goal>> _goals;
    protected int _score = 0;

    public void ListGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.Key.ToString() + ". " + goal.Value.ToString());
        }
    }

    public GoalManager()
    {
        this._goals = new List<KeyValuePair<int, Goal>>();
    }

    public void AddGoal(Goal goal)
    {
        int count = _goals.Count();
        _goals.Add(new KeyValuePair<int, Goal>(count + 1, goal));
    }

    public Goal GetGoal(int key)
    {
        return _goals.FirstOrDefault(g => g.Key == key).Value;
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.Key.ToString() + ". " + goal.Value.GetName());
        }
    }

    public int GetScore()
    {
        return _score;
    }

    public void AddPoints(int points)
    {
        _score += points;
    }

    public string GetGoals()
    {
        //return this._goals;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(_score.ToString());

        foreach (var goal in this._goals)
        {
            sb.AppendLine(goal.Value.ToStringForFile());
        }

        return sb.ToString();
    }
}