using AuthorizationManagement.Application.Enums;
using AuthorizationManagement.Application.Interfaces;

namespace AuthorizationManagement.Application.Implementations
{
    public class RoleAuthorizer : IRoleAuthorizer
    {
        private readonly IRoleManager _roleManager;
        public RoleAuthorizer(IRoleManager roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<AuthorizationStatus> AreRolesAuthorized(int[]? roleIdsToAuthorize)
        {
            var roleIds = (await _roleManager.GetAllRoles()).Select(role => role.Id);

            if (roleIdsToAuthorize == null || roleIdsToAuthorize.Count() == 0)
            {
                return AuthorizationStatus.Unauthorized;
            }

            foreach (var roleIdToAuthorize in roleIdsToAuthorize)
            {
                if (!roleIds.Contains(roleIdToAuthorize))
                {
                    return AuthorizationStatus.Unauthorized;
                }
            }

            return AuthorizationStatus.Authorized;
        }
    }
}
