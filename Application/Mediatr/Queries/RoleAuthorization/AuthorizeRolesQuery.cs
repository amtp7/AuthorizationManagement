using AuthorizationManagement.Application.Enums;
using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Queries.RoleAuthorization
{
    public record AuthorizeRolesQuery : IRequest<AuthorizationStatus>
    {
        public int[]? Ids { get; set; }
    }
}
