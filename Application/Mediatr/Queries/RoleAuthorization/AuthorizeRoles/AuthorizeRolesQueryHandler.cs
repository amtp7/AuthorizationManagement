using AuthorizationManagement.Application.Enums;
using AuthorizationManagement.Application.Interfaces;
using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Queries.RoleAuthorization.AuthorizeRoles
{
    public class AuthorizeRolesQueryHandler : IRequestHandler<AuthorizeRolesQuery, AuthorizationStatus>
    {
        private readonly IRoleAuthorizer _roleAuthorizer;

        public AuthorizeRolesQueryHandler(IRoleAuthorizer roleAuthorizer)
        {
            _roleAuthorizer = roleAuthorizer;
        }

        public async Task<AuthorizationStatus> Handle(AuthorizeRolesQuery request, CancellationToken cancellationToken)
        {
            return await _roleAuthorizer.AreRolesAuthorized(request.Ids);
        }
    }
}
