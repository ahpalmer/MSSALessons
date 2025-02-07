using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathExamples;

public class LawOfCosines
{
    public void Solve(double a, double b, double angleC)
    {
        PythagoreanTheorem pythagoreanTheorem = new PythagoreanTheorem();

        double aSquared = pythagoreanTheorem.Squared(a);
        double bSquared = pythagoreanTheorem.Squared(b);

        double twoAB = TwoTimesATimesB(a, b);
        double twoABCosC = TwoABCosC(twoAB, angleC);

        double lawOfCosCSquared = aSquared + bSquared - twoABCosC;
        double lawOfCosC = pythagoreanTheorem.SquareRoot(lawOfCosCSquared);
        Console.WriteLine(lawOfCosC);
    }
    public static double TwoTimesATimesB(double a, double b)
    {
        return 2 * a * b;
    }

    public static double TwoABCosC(double twoAB, double c)
    {
        return twoAB * Math.Cos(AngleInRadians(c));
    }

    public static double AngleInRadians(double angleC)
    {
        return angleC * (Math.PI / 180);
    }

    // Example of prioritizing brevity over simplicity
    public static double EntirePythagoreanTheorem(double a, double b)
    {
        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        return c;
    }
}
