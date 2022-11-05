using AuthorizationManagement.Application.Enums;
using AuthorizationManagement.Application.Interfaces;
using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Queries.RoleAuthorization
{
    public class AuthorizeRolesHandler : IRequestHandler<AuthorizeRolesQuery, AuthorizationStatus>
    {
        private readonly IRoleAuthorizer _roleAuthorizer;

        public AuthorizeRolesHandler(IRoleAuthorizer roleAuthorizer)
        {
            _roleAuthorizer = roleAuthorizer;
        }

        public async Task<AuthorizationStatus> Handle(AuthorizeRolesQuery request, CancellationToken cancellationToken)
        {
            return await _roleAuthorizer.AreRolesAuthorized(request.Ids);
        }
    }
}
