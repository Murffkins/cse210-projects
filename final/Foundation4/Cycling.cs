using System.Text;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double minutes, double speed)
    {
        _date = date;
        _minutes = minutes;
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        _distance = _speed * _minutes / 60;
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes} min): Distance- {this.CalculateDistance()} miles, Speed- {this.CalculateSpeed()} mph, Pace- {this.CalculatePace()} min per mile";
    }
}