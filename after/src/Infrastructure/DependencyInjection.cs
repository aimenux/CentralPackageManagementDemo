using CentralPackageManagementDemo.Application.Abstractions;
using CentralPackageManagementDemo.Infrastructure.Persistence.Contexts;
using CentralPackageManagementDemo.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CentralPackageManagementDemo.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IDummyRepository, DummyRepository>();
        services.AddDbContext<DummyDbContext>(options =>
        {
            options.UseSqlite(configuration.GetConnectionString("DummiesDBConnection"));
        });
        return services;
    }
}