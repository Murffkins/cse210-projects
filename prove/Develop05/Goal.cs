using System;

public abstract class Goal
{
    protected string _goalName = "";
    protected string _description = "";
    protected int _points = 0;
    protected bool _complete = false;
    protected int _maxComplete;
    protected int _bonusPoints = 0;
    protected int _currentComplete = 0;

    public Goal()
    {

    }

    public Goal(string goalName)
    {
        _goalName = goalName;
    }

    public void SetGoalInfo(string goalName, string description, int points)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
    }

    public void SetGoalInfo(string goalName, string description, int points, int maxComplete, int bonusPoints)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _bonusPoints = bonusPoints;
        _maxComplete = maxComplete;
    }

    public string GetName()
    {
        return _goalName;
    }

    public abstract string ToString();


    public abstract int RecordEvent();

    public string ToStringForFile()
    {
        return this.GetType()
            + "!@#$"
            + this._goalName
            + "!@#$"
            + this._description
            + "!@#$"
            + this._points.ToString()
            + "!@#$"
            + this._bonusPoints.ToString()
            + "!@#$"
            + this._complete.ToString()
            + "!@#$"
            + this._maxComplete.ToString()
            + "!@#$"
            + this._currentComplete.ToString();
    }

    public void SetComplete()
    {
        this._complete = true;
    }

    public void SetCurrentComplete(int currentComplete)
    {
        this._currentComplete = currentComplete;
    }

    public bool IsComplete()
    {
        return _complete;
    }


}