using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathExamples;

public class PythagoreanTheorem
{
    // Fields
    public double SideA;
    public double SideB;
    public double SideC;
    public double ASquared;
    public double BSquared;

    // Constructor
    public PythagoreanTheorem(double sideA, double sideB)
    {
        SideA = sideA;
        SideB = sideB;
        ASquared = Squared(SideA);
        BSquared = Squared(SideB);
        SideC = Solve();
    }

    public double Solve()
    {
        double cSquared = ASquared + BSquared;
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
