using System;

public class EternalGoal : Goal
{

    public EternalGoal() : base("Eternal")
    {

    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string ToString()
    {
        return "[ ] " + this._goalName + " (" + this._description + ")";
    }

}