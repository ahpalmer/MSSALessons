using SimpleMathExamples;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace SimpleMathExamples;

public class Program
{
    int[] numbers = new int[] { 1, 2, 3, 4, 5 };


    static void Main(string[] args)
    {
        // Pythagorean Theorem ---------------------------------------------
        PythagoreanTheorem pythagoreanTheorem = new PythagoreanTheorem();

        double a = 8;
        double b = 11;

        double c = pythagoreanTheorem.Solve(a, b);
        Console.WriteLine($"The length of the hypotenuse is: {c}");
        // Pythagorean Theorem complete ------------------------------------


        // Law of Cosines --------------------------------------------------
        LawOfCosines lawOfCosines = new LawOfCosines();

        double angleC = 37;

        lawOfCosines.Solve(a, b, angleC);
        // Law of Cosines complete -----------------------------------------
    }
}
