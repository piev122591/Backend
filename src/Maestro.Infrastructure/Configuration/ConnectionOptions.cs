
using Maestro.Infrastructure.Configuration.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Maestro.Infrastructure.Configuration
{
    /// <summary>
    /// Database connection string configuration
    /// </summary>
    public static class ConnectionOptions
    {
        //====================NOTE======================
        //Add this on your Startup.cs DatabaseConnection.ConfigureService(services,Configuration);
        //==============================================
        public static void ConfigureService(IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<ConnectionSettings>(configuration.GetSection(ConfigurationConstants.ConnectionStrings));

            services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<ConnectionSettings>>().Value);         

        }
    }
}
