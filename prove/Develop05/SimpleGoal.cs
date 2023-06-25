using System;

public class SimpleGoal : Goal
{
    public SimpleGoal() : base("Simple")
    {

    }

    public override int RecordEvent()
    {
        this._complete = true;
        return _points;
    }

    public override string ToString()
    {
        return "[" + (this.IsComplete() ? "X" : " ") + "] " + this._goalName + " (" + this._description + ")";
    }

}