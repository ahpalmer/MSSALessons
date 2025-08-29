using System;

namespace InterfacesAndDependencyInjection;

public interface IProgramStart
{
    // This is a contract.  It is a method that does not define how the method runs, only it's inputs and outputs.
    // Any class that implements this interface must have a StartAsync method that returns a Task and takes no parameters.
    Task StartAsync();
}
