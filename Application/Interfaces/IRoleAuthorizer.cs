using AuthorizationManagement.Application.Enums;

namespace AuthorizationManagement.Application.Interfaces
{
    public interface IRoleAuthorizer
    {
        public Task<AuthorizationStatus> AreRolesAuthorized(int[]? roleIds);
    }
}
