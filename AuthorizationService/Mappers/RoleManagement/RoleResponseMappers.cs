using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.AuthorizationService.Protos;

namespace AuthorizationManagement.AuthorizationService.Mappers.RoleManagement
{
    public static class RoleResponseMappers
    {
        #region GET
        public static GetRoleResponse ToResponse(this RoleDTO? role)
        {
            return role != null ? new GetRoleResponse { RoleId = role.Id, RoleName = role.Name } : new GetRoleResponse();
        }

        public static GetAllRolesResponse ToResponse(this IEnumerable<RoleDTO> rolesToMap)
        {
            var roles = rolesToMap.Select(roleToMap => new GetRoleResponse { RoleId = roleToMap.Id, RoleName = roleToMap.Name });
            var response = new GetAllRolesResponse();
            response.Roles.Add(roles);
            return response;
        }
        #endregion

        #region CREATE
        public static CreateRoleResponse ToResponse(this int roleId)
        {
            return new CreateRoleResponse { RoleId = roleId };
        }
        #endregion
    }
}
