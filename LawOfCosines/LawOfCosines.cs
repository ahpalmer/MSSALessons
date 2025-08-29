using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathExamples;

public class LawOfCosines
{
    // private PythagoreanTheorem _pythagoraeanTheorem;

    // // Constructor.  This is the instruction manual for how you instantiate the class!
    // public LawOfCosines(PythagoreanTheorem pythagoreanTheorem)
    // {
    //     _pythagoraeanTheorem = pythagoreanTheorem;
    // }

    public double Solve(double a, double b, double angleC)
    {
        PythagoreanTheorem pythagoreanTheorem = new PythagoreanTheorem();

        double aSquared = pythagoreanTheorem.Squared(a);
        double bSquared = pythagoreanTheorem.Squared(b);

        double twoAB = TwoTimesATimesB(a, b);
        double twoABCosC = TwoABCosC(twoAB, angleC);

        double lawOfCosCSquared = aSquared + bSquared - twoABCosC;
        double lawOfCosC = pythagoreanTheorem.SquareRoot(lawOfCosCSquared);
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

    // Example of prioritizing brevity over simplicity
    // This method is equivalent to the four methods above combined into one.
    public double EntirePythagoreanTheorem(double a, double b)
    {
        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        return c;
    }
}
