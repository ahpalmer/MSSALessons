using System;

namespace InterfacesAndDependencyInjection;

public class ProgramStart : IProgramStart
{
    private ILawOfCosines _lawOfCosines;
    private IPythagoreanTheorem _pythagoreanTheorem;

    public ProgramStart(ILawOfCosines lawOfCosines, IPythagoreanTheorem pythagoreanTheorem)
    {
        _lawOfCosines = lawOfCosines;
        _pythagoreanTheorem = pythagoreanTheorem;
    }

    // We did not have to instantiate LawOfCosines or PythagoreanTheorem here.  The Dependency Injection framework did that for us!
    public async Task StartAsync()
    {
        // Compare this method to the Main method in SimpleMathExamples.Program.cs
        Console.WriteLine("Starting program...");



        // Pythagorean Theorem ---------------------------------------------
        // Didn't need to instantiate the pythagorean theorem class, Dependency injection already did it
        double a = 8;
        double b = 11;

        double c = _pythagoreanTheorem.Solve(a, b);
        Console.WriteLine($"The length of the hypotenuse is: {c}");
        // Pythagorean Theorem complete ------------------------------------




        // Law of Cosines --------------------------------------------------
        // Didn't need to instantiate the Law of Cosines class, Dependency injection already did it

        double angleC = 37;

        double answer = _lawOfCosines.Solve(a, b, angleC);
        // Law of Cosines complete -----------------------------------------


        Console.WriteLine($"The length of the third side is: {answer}");

        Console.WriteLine("Program complete.");
    }
}
