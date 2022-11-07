using AuthorizationManagement.Domain.Entities;

namespace AuthorizationManagement.Application.Interfaces
{
    public interface IRoleRepositoryMock
    {
        public Task<Role?> GetRole(int id);
        public Task<List<Role>> GetAllRoles();
        public Task CreateRole(Role role);
        public Task UpdateRole(Role role);
        public Task DeleteRole(int id);
    }
}
