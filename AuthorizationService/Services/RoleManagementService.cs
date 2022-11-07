using AuthorizationManagement.Application.Mediatr.Commands.RoleManagement.CreateRole;
using AuthorizationManagement.Application.Mediatr.Queries.RoleManagement.GetAllRoles;
using AuthorizationManagement.Application.Mediatr.Queries.RoleManagement.GetRole;
using AuthorizationManagement.AuthorizationService.Mappers.RoleManagement;
using AuthorizationManagement.AuthorizationService.Protos;
using Grpc.Core;
using MediatR;

namespace AuthorizationManagement.AuthorizationService.Services
{
    public class RoleManagementService : RoleManagement.RoleManagementBase
    {
        private readonly ILogger<RoleManagementService> _logger;
        private readonly IMediator _mediator;

        public RoleManagementService(ILogger<RoleManagementService> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public override async Task<GetRoleResponse> GetRole(GetRoleRequest request, ServerCallContext context)
        {
            var result = await _mediator.Send(new GetRoleQuery
            {
                Id = request.RoleId
            });

            return result.ToResponse();
        }

        public override async Task<GetAllRolesResponse> GetAllRoles(Empty request, ServerCallContext context)
        {
            var result = await _mediator.Send(new GetAllRolesQuery());

            return result.ToResponse();
        }

        public override async Task<CreateRoleResponse> CreateRole(CreateRoleRequest request, ServerCallContext context)
        {
            var result = await _mediator.Send(new CreateRoleCommand
            {
                Id = request.RoleId,
                Name = request.RoleName
            });

            return result.ToResponse();
        }
    }
}