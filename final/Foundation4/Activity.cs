using System.Text;

public abstract class Activity
{
    protected string _date;
    protected double _minutes;
    protected double _distance;

    public virtual double CalculateDistance()
    {
        return _distance;
    }

    public virtual double CalculateSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public virtual double CalculatePace()
    {
        return _minutes / _distance;
    }

    public abstract string GetSummary();

}