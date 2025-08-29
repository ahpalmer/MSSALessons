using Microsoft.Extensions.DependencyInjection;

namespace InterfacesAndDependencyInjection;

public class Program
{
    public static async Task Main(string[] args)
    {
        // Set up Dependency Injection.  This is just fancy, cloud instantiation!
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IProgramStart, ProgramStart>()
            .BuildServiceProvider();

        var service = serviceProvider.GetService<IProgramStart>()!;

        if (service != null)
        {
            await service.StartAsync();
        }
    }
}
