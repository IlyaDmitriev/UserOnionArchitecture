using ConsoleUI.Interfaces;
using ConsoleUI.Services;
using DbContext.Services;
using Microsoft.Extensions.DependencyInjection;
using UserApplication.Interfaces;
using UserApplication.Services;
using UserDomain.Interfaces;
using UserInfrastructure.Interfaces;
using UserInfrastructure.Services;

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            // create service collection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // create service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // entry to run app
            serviceProvider.GetService<UserApp>().Run();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            // add services
            serviceCollection.AddTransient<IConsoleProvider, ConsoleProvider>();
            serviceCollection.AddTransient<IUserConsoleService, UserConsoleService>();
            serviceCollection.AddTransient<IContext, ContextService>();
            serviceCollection.AddTransient<IUserAddCommand, UserAddCommandService>();
            serviceCollection.AddTransient<IConsoleProvider, ConsoleProvider>();
            serviceCollection.AddTransient<IUserService, UserService>();


            // add app
            serviceCollection.AddTransient<UserApp>();
        }
    }
}
