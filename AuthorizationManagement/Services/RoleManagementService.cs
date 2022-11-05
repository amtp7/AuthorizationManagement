using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.Application.Mediatr.Queries.RoleManagement;
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

        public override async Task<GetRoleResponse?> GetRole(GetRoleRequest request, ServerCallContext context)
        {
            return ToResponse(await _mediator.Send(new GetRoleQuery { Id = request.RoleId }));
        }

        private GetRoleResponse ToResponse(RoleDTO? role)
        {
            return role != null ? new GetRoleResponse { RoleId = role.Id, RoleName = role.Name } : new GetRoleResponse();
        }
    }
}