using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Notes.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppliction(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
        
    }
}