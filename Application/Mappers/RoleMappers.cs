using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.Domain.Entities;

namespace AuthorizationManagement.Application.Mappers
{
    public static class RoleMappers
    {
        public static RoleDTO ToDTO(this Role role)
        {
            return new RoleDTO
            {
                Id = role.Id,
                Name = role.Name
            };
        }
        public static Role ToDomain(this RoleDTO role)
        {
            return new Role
            {
                Id = role.Id,
                Name = role.Name
            };
        }
        public static List<RoleDTO> ToDTO(this List<Role> roles)
        {
            return roles.Select(role => role.ToDTO()).ToList();
        }
        public static List<Role> ToDomain(this List<RoleDTO> roles)
        {
            return roles.Select(role => role.ToDomain()).ToList();
        }
    }
}
