using CentralPackageManagementDemo.Api.Extensions;
using CentralPackageManagementDemo.Application;
using CentralPackageManagementDemo.Infrastructure;

namespace CentralPackageManagementDemo.Api;

public class Startup
{
    public void ConfigureServices(WebApplicationBuilder builder)
    {
        builder
            .AddApi()
            .AddApplication()
            .AddInfrastructure(builder.Configuration);
    }

    public void Configure(WebApplication app)
    {
        app.UseHttpLogging();
        app.UseSwaggerDoc();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
    }
}