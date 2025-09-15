using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a default fraction 0/1
        Fraction fraction1 = new Fraction();
        Console.WriteLine("Fraction1: " + fraction1.GetFractionString() + " = " + fraction1.GetDecimalValue());

        // Create a fraction from a whole number 5/1
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine("Fraction2: " + fraction2.GetFractionString() + " = " + fraction2.GetDecimalValue());

        // Create a fraction with numerator 3 and denominator 4
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine("Fraction3: " + fraction3.GetFractionString() + " = " + fraction3.GetDecimalValue());

        // Modify fraction3 using setters
        fraction3.SetTop(7);
        fraction3.SetBottom(8);
        Console.WriteLine("Modified Fraction3: " + fraction3.GetFractionString() + " = " + fraction3.GetDecimalValue());
    }
}
