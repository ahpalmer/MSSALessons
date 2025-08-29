using System;
using OOPClassInstantiationExamples;

namespace OOPClassInstantiationExamples;

public class Program
{
    public static void Main(string[] args)
    {
        // How do you instantiate (create objects) from classes?
        // Rule: always think of how an object is instantiated.

        // Let's look at the standard object: a public class.  Our example is called "StandardPublicClass"
        // Can you run a method from this class?  Let's try
        // StandardPublicClass.DisplayMessage();

        // Did it work?  No, because we need to create an object from the class first.
        StandardPublicClass standardPublicClass = new StandardPublicClass();
        standardPublicClass.DisplayMessage();

        // What have we done here?
        // 1. We created a class named "StandardPublicClass".  This is the thing in green text.  Think of this as a blueprint.
        // 2. We created an object from the class named "standardPublicClass".  This is the 'object' of Object-oriented-programming.  This is the thing in blue text.  Think of this as the house you built from the blueprint.
        // 3. We called the method "DisplayMessage" from the object "standardPublicClass".

        // Now let's look at a static class.  Our example is called "StaticClass"
        // Can you run a method from this class?  Let's try
        StaticClass.StaticDisplayMessage();

        // Did it work?  Yes, because static classes do not need to be instantiated (no object creation needed).
        // The class is automatically instantiated by the compiler.  Static classes are confusing because they break our rule: always think of how an object is instantiated.
        // Static classes are used for utility or helper classes, or when you want to group methods together that do not need to be instantiated.


        // Much more complicated instantiation:
        PythagoreanTheoremInstatiation pythagoreanTheorem = new PythagoreanTheoremInstatiation(8, 11);
        LawOfCosines lawOfCosines = new LawOfCosines(pythagoreanTheorem);
        double answer = lawOfCosines.Solve(37);
        Console.WriteLine(answer);
    }
}
