using System.Text;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double minutes, int laps)
    {
        _date = date;
        _minutes = minutes;
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        _distance = _laps * 50 / 1000 * 0.62;
        return _distance;
    }

    public override double CalculatePace()
    {
        return _minutes / CalculateDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes} min): Distance- {this.CalculateDistance()} miles, Speed- {this.CalculateSpeed()} mph, Pace- {Math.Round(this.CalculatePace(), 2)} min per mile";
    }
}