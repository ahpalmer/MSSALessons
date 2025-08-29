using System;

namespace InterfacesAndDependencyInjection;

public class ProgramStart : IProgramStart
{
    public async Task StartAsync()
    {
        Console.WriteLine("Starting program...");

        Console.WriteLine("Program complete.");
    }
}
