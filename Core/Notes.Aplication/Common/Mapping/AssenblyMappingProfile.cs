using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using AutoMapper;

namespace Notes.Aplication.Common.Mapping
{
    public class AssenblyMappingProfile: Profile
    {
        public AssenblyMappingProfile(Assenbly assembly) =>
            ApplyMappingFromAssembly(assembly);
        
        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(type => type.GetInterfaces()
                .Any(i => i.IsGenericType &&
                i.GetGenerucTypeDefenition() == typeof(IMapWith<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] {this});
            }
        }

    
    }
}