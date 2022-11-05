using AuthorizationManagement.Application.Interfaces;
using AuthorizationManagement.AuthorizationService.Protos;
using Grpc.Core;

namespace AuthorizationManagement.AuthorizationService.Services
{
    public class AuthorizationService : Authorization.AuthorizationBase
    {
        private readonly ILogger<AuthorizationService> _logger;
        private readonly IAuthorize _authorize;

        public AuthorizationService(ILogger<AuthorizationService> logger, IAuthorize authorize)
        {
            _logger = logger;
            _authorize = authorize;
        }

        public override Task<GetRoleResponse> GetRole(GetRoleRequest request, ServerCallContext context)
        {
            if (request.RoleId == 1)
            {
                return Task.FromResult(new GetRoleResponse
                {
                    RoleId = 1,
                    RoleName = "Manager"
                });
            }
            else
            {
                return Task.FromResult(new GetRoleResponse
                {
                    RoleId = 2,
                    RoleName = "Developer"
                });
            }
        }
    }
}