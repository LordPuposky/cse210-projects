// Class Fraction to represent a mathematical fraction
public class Fraction
{
    // Attribute for the numerator (top number)
    private int _top;

    // Attribute for the denominator (bottom number)
    private int _bottom;

    // Default constructor: Initializes fraction to 0/1
    public Fraction()
    {
        _top = 0;
        _bottom = 1;
    }

    // Constructor: Initializes fraction with a whole number, denominator set to 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor: Initializes fraction with top (numerator) and bottom (denominator)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for _top (numerator)
    public int GetTop()
    {
        return _top;
    }

    // Setter for _top (numerator)
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for _bottom (denominator)
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for _bottom (denominator)
    public void SetBottom(int bottom)
    {
        // Optionally ensure denominator is not zero
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            throw new System.ArgumentException("Denominator cannot be zero.");
        }
    }

    // Method to return the fraction as a string, e.g., "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value of the fraction as a double
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
