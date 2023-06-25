using System;

public class ChecklistGoal : Goal
{
    // private int _maxComplete = 0;
    // private int _bonusPoints = 0;

    public ChecklistGoal() : base("Checklist")
    {

    }

    public override int RecordEvent()
    {
        _currentComplete++;
        if (_currentComplete == _maxComplete)
        {
            this._complete = true;
            return _points + _bonusPoints;
        }
        return _points;
    }

    private string GoalProgress()
    {
        return $"Currently completed: {this._currentComplete}/{this._maxComplete}";
    }

    public override string ToString()
    {
        return "[" + (this.IsComplete() ? "X" : " ") + "] " + this._goalName + " (" + this._description + ") -- " + this.GoalProgress();
    }

    public int GetCurrentComplete()
    {
        return this._currentComplete;
    }

}