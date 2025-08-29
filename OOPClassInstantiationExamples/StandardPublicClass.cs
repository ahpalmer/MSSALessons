namespace OOPClassInstantiationExamples;

public class StandardPublicClass
{
    public void DisplayMessage()
    {
        Console.WriteLine("This is a message from a standard public class.");
    }

    // You CAN have static methods in a non-static class
    public static void DisplayStaticMessageFromStandardClass()
    {
        Console.WriteLine("This is a static message from a standard public class.");
    }
}
