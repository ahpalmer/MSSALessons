namespace InterfacesAndDependencyInjection;

public class LawOfCosines : ILawOfCosines
{
    private IPythagoreanTheorem _pythagoreanTheorem;

    // Constructor.  This is the instruction manual for how you instantiate the class!
    public LawOfCosines(IPythagoreanTheorem pythagoreanTheorem)
    {
        _pythagoreanTheorem = pythagoreanTheorem;
    }

    public double Solve(double a, double b, double angleC)
    {
        double aSquared = _pythagoreanTheorem.Squared(a);
        double bSquared = _pythagoreanTheorem.Squared(b);

        double twoAB = TwoTimesATimesB(a, b);
        double twoABCosC = TwoABCosC(twoAB, angleC);

        double lawOfCosCSquared = aSquared + bSquared - twoABCosC;
        double lawOfCosC = _pythagoreanTheorem.SquareRoot(lawOfCosCSquared);
        Console.WriteLine(lawOfCosC);
        return lawOfCosC;
    }
    public double TwoTimesATimesB(double a, double b)
    {
        return 2 * a * b;
    }

    public double TwoABCosC(double twoAB, double c)
    {
        return twoAB * Math.Cos(AngleInRadians(c));
    }

    public double AngleInRadians(double angleC)
    {
        return angleC * (Math.PI / 180);
    }
}
