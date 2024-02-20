
using Api.Data;
using Api.Domain.Interfaces;
using Api.Repository;
using Api.Service;
using Microsoft.EntityFrameworkCore;

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
        services.AddDbContext<AppDbContext>(x => x.UseNpgsql(configuration.GetConnectionString("ClienteDataConnection")));
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
