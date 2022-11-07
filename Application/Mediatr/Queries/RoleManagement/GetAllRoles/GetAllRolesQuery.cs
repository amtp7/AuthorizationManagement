using AuthorizationManagement.Application.DTOs;
using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Queries.RoleManagement.GetAllRoles
{
    public record GetAllRolesQuery : IRequest<IEnumerable<RoleDTO>>
    {
    }
}
