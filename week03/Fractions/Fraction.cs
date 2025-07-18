public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Default constructor: 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with numerator
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter and Setter for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getter and Setter for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Return as string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Return as decimal
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
