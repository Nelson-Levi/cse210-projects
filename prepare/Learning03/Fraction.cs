using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // This is the default constructor. It will construct an object with no parameters provided.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // This is another possible constructor. It will construct an object with one parameter provided.
    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    // This is another possible constructor. It will construct an object with two parameters provided.
    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public string GetFractionString()
    {
        string fractionText = $"{_top}/{_bottom}";
        return fractionText;
    }

    public double GetDecimalValue()
    {
        double fractionDecimal = (double)_top/(double)_bottom;
        return fractionDecimal; 
    }

}