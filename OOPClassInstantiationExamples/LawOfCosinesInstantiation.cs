using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathExamples;

public class LawOfCosines
{
    private PythagoreanTheorem _pythagoraeanTheorem;

    // Constructor.  This is the instruction manual for how you instantiate the class!
    public LawOfCosines(PythagoreanTheorem pythagoreanTheorem)
    {
        _pythagoraeanTheorem = pythagoreanTheorem;
    }

    public double Solve(
        PythagoreanTheorem pythagoreanTheorem,
        double angleC)
    {
        double twoAB = TwoTimesATimesB(pythagoreanTheorem._sideA, pythagoreanTheorem._sideB);
        double twoABCosC = TwoABCosC(twoAB, angleC);

        double lawOfCosCSquared = pythagoreanTheorem._aSquared + pythagoreanTheorem._bSquared - twoABCosC;
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
}
