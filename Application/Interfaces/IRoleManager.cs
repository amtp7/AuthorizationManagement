using AuthorizationManagement.Application.DTOs;

namespace AuthorizationManagement.Application.Interfaces
{
    public interface IRoleManager
    {
        public Task<RoleDTO?> GetRole(int id);
        public Task<List<RoleDTO>> GetAllRoles();
        public Task CreateRole(RoleDTO role);
        public Task UpdateRole(RoleDTO role);
        public Task DeleteRole(int id);
    }
}
