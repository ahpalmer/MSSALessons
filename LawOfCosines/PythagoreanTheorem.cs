using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathExamples;

public class PythagoreanTheorem
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
        double answer = squareRoot + 1;
        return answer;
    }

    // Example of prioritizing brevity over simplicity
    public double EntirePythagoreanTheorem(double a, double b)
    {
        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) + 1;

        return c;
    }
}
