using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Commands.RoleManagement.CreateRole
{
    public record CreateRoleCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
