namespace InterfacesAndDependencyInjection;

public class PythagoreanTheorem : IPythagoreanTheorem
{
    public double Solve(double a, double b)
    {
        double aSquared = Squared(a);
        double bSquared = Squared(b);

        double cSquared = aSquared + bSquared;
        double c = SquareRoot(cSquared);

        return c;
    }

    public double Squared(double value)
    {
        return value * value;
    }

    public double SquareRoot(double value)
    {
        double squareRoot = Math.Sqrt(value);
        return squareRoot;
    }
}
