
using Maestro.Infrastructure.Contracts;
using Maestro.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Maestro.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddMaestroInfrastructure(this IServiceCollection services)
        {
            #region Maestro Infrastructure Shared 

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IConnectionFactory, ConnectionFactory>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #endregion
                   

            return services;

        }
    }
}
