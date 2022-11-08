using AuthorizationManagement.Application.Interfaces;
using AuthorizationManagement.Domain.Entities;

namespace AuthorizationManagement.Infrastructure.RoleRepositoryMock
{
    public class RoleRepositoryMock : IRoleRepositoryMock
    {
        private static List<Role> roles;

        public RoleRepositoryMock()
        {
            roles = new List<Role>
            {
                new Role { Id = 1, Name = "Manager" },
                new Role { Id = 2, Name = "Senior" },
                new Role { Id = 3, Name = "Mid" },
                new Role { Id = 4, Name = "Junior" }
            };
        }

        public async Task<Role?> GetRole(int id)
        {
            return await Task.FromResult(roles.SingleOrDefault(role => role.Id == id));
        }

        public async Task<List<Role>> GetAllRoles()
        {
            return await Task.FromResult(roles);
        }

        public async Task<int> CreateRole(Role role)
        {
            roles.Add(role);
            await Task.CompletedTask;
            return role.Id;
        }
    }
}
