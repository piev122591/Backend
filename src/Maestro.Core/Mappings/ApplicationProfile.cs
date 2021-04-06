using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Maestro.Core.Mappings
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());

            ApplyMappingsToDestinationAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(t => t.GetInterfaces()
                .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapSource<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);

                var methodInfo = type.GetMethod("Mapping")
                    ?? type.GetInterface("IMapSource`1").GetMethod("Mapping");

                methodInfo?.Invoke(instance, new object[] { this });

            }
        }

        private void ApplyMappingsToDestinationAssembly(Assembly assembly)
        {

            var types = assembly.GetExportedTypes()
              .Where(t => t.GetInterfaces()
              .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapDestination<>)))
              .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);

                var methodInfo = type.GetMethod("Mapping")
                    ?? type.GetInterface("IMapDestination`1").GetMethod("Mapping");

                methodInfo?.Invoke(instance, new object[] { this });

            }

        }
    }
}
