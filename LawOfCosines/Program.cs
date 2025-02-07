using SimpleMathExamples;
using System.Net.NetworkInformation;

namespace SimpleMathExamples
{
    public class Program
    {

        static void Main(string[] args)
        {
            // Pythagorean Theorem:
            PythagoreanTheorem pythagoreanTheorem = new PythagoreanTheorem();

            double a = 8;
            double b = 11;

            pythagoreanTheorem.Solve(a, b);
            // Pythagorean Theorem complete

            // More examples:
            // Law of Cosines:
            LawOfCosines lawOfCosines = new LawOfCosines();

            double angleC = 37;

            lawOfCosines.Solve(a, b, angleC);
            // Law of Cosines complete
        }

    }
}
