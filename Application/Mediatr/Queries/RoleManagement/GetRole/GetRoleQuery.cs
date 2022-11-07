using AuthorizationManagement.Application.DTOs;
using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Queries.RoleManagement.GetRole
{
    public record GetRoleQuery : IRequest<RoleDTO?>
    {
        public int Id { get; set; }
    }
}
