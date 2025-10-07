// Class for squares
public class Square : Shape
{
    // Side length
    private double _side;

    // Constructor calls base for color and sets the side
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override area calculation
    public override double GetArea()
    {
        return _side * _side;
    }
}
