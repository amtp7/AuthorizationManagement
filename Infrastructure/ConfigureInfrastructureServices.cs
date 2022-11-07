using AuthorizationManagement.Application.Interfaces;
using AuthorizationManagement.Infrastructure.RoleRepositoryMock;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigureInfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IRoleRepositoryMock, RoleRepositoryMock>();

            return services;
        }
    }
}