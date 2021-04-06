
using Maestro.Core.Interfaces;
using Maestro.Core.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Maestro.Core
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddMaestroCore(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddTransient<IDateAndTime, DateAndTime>();

            return services;

        }
    }
}
