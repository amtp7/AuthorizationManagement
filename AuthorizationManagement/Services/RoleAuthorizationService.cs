using AuthorizationManagement.Application.Mediatr.Queries.RoleAuthorization;
using AuthorizationManagement.AuthorizationService.Protos;
using Grpc.Core;
using MediatR;

namespace AuthorizationManagement.AuthorizationService.Services
{
    public class RoleAuthorizationService : RoleAuthorization.RoleAuthorizationBase
    {
        private readonly ILogger<RoleAuthorizationService> _logger;
        private readonly IMediator _mediator;

        public RoleAuthorizationService(ILogger<RoleAuthorizationService> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public override async Task<AuthorizeRolesResponse> AuthorizeRoles(AuthorizeRolesRequest request, ServerCallContext context)
        {
            var response = (await _mediator.Send(new AuthorizeRolesQuery { Ids = request.RoleIds.ToArray() })).ToString();

            return new AuthorizeRolesResponse { AuthorizationStatus = response.ToString() };
        }
    }
}