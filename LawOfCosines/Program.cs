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

    public static int DataStructureList()
    {
        // Size does change
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //numbers.Count();

        numbers.Add(11);

        return numbers.Sum();
    }

    public static int DataStructureArray()
    {
        // Size doesn't change
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        return numbers.Sum();
    }
}
