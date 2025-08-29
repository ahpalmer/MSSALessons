namespace InterfacesAndDependencyInjection;

// This is a contract. Any class that inherits this interface must define these three methods:
public interface ILawOfCosines
{
    public double Solve(double a, double b, double angleC);

    public double TwoTimesATimesB(double a, double b);

    public double TwoABCosC(double twoAB, double c);

    public double AngleInRadians(double angleC);
}
