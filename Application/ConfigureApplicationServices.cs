using AuthorizationManagement.Application.Implementations;
using AuthorizationManagement.Application.Interfaces;
using System.Reflection;
using MediatR;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigureApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {          
            services.AddTransient<IRoleManager, RoleManager>();
            services.AddTransient<IRoleAuthorizer, RoleAuthorizer>();
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}