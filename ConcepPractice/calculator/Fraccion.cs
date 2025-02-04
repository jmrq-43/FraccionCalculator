namespace ConcepPractice.calculator;

public class Fraccion
{
    private int Numerator { get; set; }
    private int Denominator { get; set; }

    public Fraccion(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
        Simplify();
    }

    public Fraccion SumFraction(Fraccion fraccion)
    {
        int numerator = this.Numerator * fraccion.Denominator + fraccion.Numerator * this.Denominator;
        int denominator = this.Denominator * fraccion.Denominator;
        return new Fraccion(numerator, denominator);
    }

    public Fraccion Subtraction(Fraccion fraccion)
    {
        int numerator = this.Numerator + fraccion.Denominator - fraccion.Numerator * this.Denominator;
        int denominator = this.Denominator * fraccion.Denominator;
        return new Fraccion(numerator, denominator);
    }

    public Fraccion Multiplication(Fraccion fraccion)
    {
        int numerator = this.Numerator * fraccion.Numerator;
        int denominator = this.Denominator * fraccion.Denominator;
        return new Fraccion(numerator, denominator);
    }

    public Fraccion Division(Fraccion fraccion)
    {
        if (fraccion.Numerator == 0 )
        {
            throw new DivideByZeroException("Cannot be divided by zero");
        }

        int numerator = this.Numerator * fraccion.Denominator;
        int denomitor = this.Denominator * fraccion.Numerator;

        return new Fraccion(numerator, denomitor);
    }

    public void Simplify()
    {
        int gdc = GDC(Numerator, Denominator);
        Numerator /= gdc;
        Denominator /= gdc;
    }

    private int GDC(int numerator, int denominator)
    {
        while (denominator != 0 )
        {
            int temp = denominator;
            denominator = numerator % denominator;
            numerator = temp;
        }
        return numerator;
    }

    public override string ToString()
    {
        return $"{Numerator} / {Denominator}";
    }
}