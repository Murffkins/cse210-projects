public class Circle : Shape
{
    private double _radius = 0;

    public Circle(string color, double radius) : base ("Circle", color)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public void SetLength(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.Round(Math.PI * (_radius * _radius), 2);
    }
}