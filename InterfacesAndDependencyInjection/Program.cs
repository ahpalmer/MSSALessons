using Microsoft.Extensions.DependencyInjection;

namespace InterfacesAndDependencyInjection;

public class Program
{
    public static async Task Main(string[] args)
    {
        // Set up Dependency Injection.  This is just fancy, cloud instantiation.  Right now the program is creating an object out of all of your classes.
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IProgramStart, ProgramStart>()
            .AddSingleton<IPythagoreanTheorem, PythagoreanTheorem>()
            .AddSingleton<ILawOfCosines, LawOfCosines>()
            .BuildServiceProvider();

        var service = serviceProvider.GetService<IProgramStart>()!;

        if (service != null)
        {
            // This is the method that will run when you Run this program.  Consider this your "Main" method.
            await service.StartAsync();
        }
    }
}
