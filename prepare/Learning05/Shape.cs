public class Shape
{
    private string _shapeName = "";
    protected string _color = "";

    public Shape(string shapeName, string color)
    {
        _shapeName = shapeName;
        _color = color;
    }

    public string GetShape()
    {
        return _shapeName;
    }

    public void SetShape(string shapeName)
    {
        _shapeName = shapeName;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return -1;
    }
    
}