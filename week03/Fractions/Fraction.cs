public class Fraction
{
    // Private attributes to encapsulate the numerator and denominator
    private int _numerator;
    private int _denominator;

    // Constructor 1: No parameters, initializes to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor 2: One parameter for numerator, denominator set to 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor 3: Two parameters for numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    // Setter for numerator
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    // Setter for denominator
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Returns fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Returns fraction as a decimal value (e.g., 0.75 for 3/4)
    public double GetDecimalValue()
    {
        // Avoid division by zero
        if (_denominator == 0)
        {
            return 0.0; // Could throw an exception in a real application
        }
        return (double)_numerator / _denominator;
    }
}