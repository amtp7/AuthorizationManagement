using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.Domain.Entities;

namespace AuthorizationManagement.Application.Mappers
{
    public static class RoleMappers
    {
        public static RoleDTO? ToDTO(this Role? role)
        {
            return role == null
                ? null
                : new RoleDTO
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

        public static IEnumerable<RoleDTO?> ToDTO(this IEnumerable<Role?> roles)
        {
            return roles.Where(role => role != null).Select(role => role.ToDTO());
        }

        public static IEnumerable<Role> ToDomain(this IEnumerable<RoleDTO> roles)
        {
            return roles.Where(role => role != null).Select(role => role.ToDomain());
        }
    }
}
