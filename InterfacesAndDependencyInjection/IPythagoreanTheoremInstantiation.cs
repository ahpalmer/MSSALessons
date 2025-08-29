namespace InterfacesAndDependencyInjection;

// This is a contract. Any class that inherits this interface must define these three methods:
// Solve, Squared, and SquareRoot
public interface IPythagoreanTheorem
{
    public double Solve(double a, double b);

    public double Squared(double value);

    public double SquareRoot(double value);

}
