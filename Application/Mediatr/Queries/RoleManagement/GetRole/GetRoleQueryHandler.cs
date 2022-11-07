using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.Application.Interfaces;
using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Queries.RoleManagement.GetRole
{
    public class GetRoleQueryHandler : IRequestHandler<GetRoleQuery, RoleDTO?>
    {
        private readonly IRoleManager _roleManager;

        public GetRoleQueryHandler(IRoleManager roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<RoleDTO?> Handle(GetRoleQuery request, CancellationToken cancellationToken)
        {
            return await _roleManager.GetRole(request.Id);
        }
    }
}
