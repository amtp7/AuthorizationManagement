using AuthorizationManagement.Application.DTOs;
using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Queries.RoleManagement
{
    public record GetRoleQuery : IRequest<RoleDTO?>
    {
        public int Id { get; set; }
    }
}
