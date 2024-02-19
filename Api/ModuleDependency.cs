
using Api.Domain.Interfaces;
using Api.Repository;
using Api.Service;

namespace Api;

public static class ModuleDependency
{
    public static void AddModule(this IServiceCollection services, ConfigurationManager configuration)
    {
        AddDataContext(services, configuration);
        AddServices(services);
        AddRepositories(services);
    }

    private static void AddDataContext(IServiceCollection services, ConfigurationManager configuration)
    {
    }

    private static void AddServices(IServiceCollection services)
    {
        services.AddTransient<IClienteService, ClienteService>();
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddTransient<IClienteRepository, ClienteRepository>();
    }
}
