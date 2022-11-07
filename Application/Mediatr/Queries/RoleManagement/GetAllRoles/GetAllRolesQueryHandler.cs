using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.Application.Interfaces;
using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Queries.RoleManagement.GetAllRoles
{
    public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, IEnumerable<RoleDTO?>>
    {
        private readonly IRoleManager _roleManager;

        public GetAllRolesQueryHandler(IRoleManager roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<IEnumerable<RoleDTO?>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            return await _roleManager.GetAllRoles();
        }
    }
}
