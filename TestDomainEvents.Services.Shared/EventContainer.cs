using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TestDomainEvents.Services.Shared
{
    public static class EventContainer
    {
        public static List<Type> GetAll<T>()
        {
            return Assembly.GetCallingAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i == typeof (T)))
                .ToList();
        }

        public static List<Type> GetAll<T>(Assembly assembly)
        {
            return assembly
                .GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i == typeof(T)))
                .ToList();
        }
    }
}
