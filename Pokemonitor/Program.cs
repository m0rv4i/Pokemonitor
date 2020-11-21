using Pokemonitor.Scanner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Pokemonitor
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var scanner = serviceProvider.GetService<ProcessScanner>();

            scanner.ScanProcess(null);

            serviceProvider.Dispose();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure =>
                configure.AddConsole()
                .AddDebug())
                .Configure<LoggerFilterOptions>(options => options.MinLevel = LogLevel.Information)
                .AddTransient<ProcessScanner>();
        }
    }
}
