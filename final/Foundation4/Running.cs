using System.Text;

public class Running : Activity
{
    public Running(string date, double minutes, double distance)
    {
        _date = date;
        _minutes = minutes;
        _distance = distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes} min): Distance- {this.CalculateDistance()} miles, Speed- {this.CalculateSpeed()} mph, Pace- {this.CalculatePace()} min per mile";
    }
}