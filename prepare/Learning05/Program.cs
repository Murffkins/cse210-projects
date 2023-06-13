using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();
        
        Square shape1 = new Square("Red", 5);
        shapeList.Add(shape1);

        Rectangle shape2 = new Rectangle("Blue", 4, 8);
        shapeList.Add(shape2);

        Circle shape3 = new Circle("Green", 3);
        shapeList.Add(shape3);

        foreach (Shape shape in shapeList)
        {
            string shapeName = shape.GetShape();

            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} {shapeName} has an area of {area}.");
        }
    }
}