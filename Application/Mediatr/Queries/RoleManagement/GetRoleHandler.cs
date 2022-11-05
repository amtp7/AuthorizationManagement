using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.Application.Interfaces;
using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Queries.RoleManagement
{
    public class GetRoleHandler : IRequestHandler<GetRoleQuery, RoleDTO?>
    {
        private readonly IRoleManager _roleManager;

        public GetRoleHandler(IRoleManager roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<RoleDTO?> Handle(GetRoleQuery request, CancellationToken cancellationToken)
        {
            return await _roleManager.GetRole(request.Id);
        }
    }
}
