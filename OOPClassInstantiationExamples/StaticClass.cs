namespace OOPClassInstantiationExamples;

public static class StaticClass
{
    public static void StaticDisplayMessage()
    {
        Console.WriteLine("This is a message from a static class.");
    }

    // you CANNOT have non-static methods in a static class
    // Uncommenting the code below will cause a compile error
    // public void NonStaticMethod()
    // {
    //     Console.WriteLine("This method cannot be called because the class is static.");
    // }
}
