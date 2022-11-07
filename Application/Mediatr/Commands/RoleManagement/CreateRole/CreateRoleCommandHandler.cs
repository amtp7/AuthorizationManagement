using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.Application.Interfaces;
using MediatR;

namespace AuthorizationManagement.Application.Mediatr.Commands.RoleManagement.CreateRole
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, int>
    {
        private readonly IRoleManager _roleManager;

        public CreateRoleCommandHandler(IRoleManager roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<int> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            return await _roleManager.CreateRole(new RoleDTO { Id = request.Id, Name = request.Name });
        }
    }
}
