using AuthorizationManagement.Domain.Entities;

namespace AuthorizationManagement.Application.Interfaces
{
    public interface IRoleRepositoryMock
    {
        public Task<Role?> GetRole(int id);
        public Task<List<Role>> GetAllRoles();
        public Task<int> CreateRole(Role role);
    }
}
