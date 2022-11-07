using AuthorizationManagement.Application.DTOs;

namespace AuthorizationManagement.Application.Interfaces
{
    public interface IRoleManager
    {
        public Task<int> CreateRole(RoleDTO role);
        public Task<IEnumerable<RoleDTO?>> GetAllRoles();
        public Task<RoleDTO?> GetRole(int id);
    }
}
