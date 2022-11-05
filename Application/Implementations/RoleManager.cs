using AuthorizationManagement.Application.Mappers;
using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.Application.Interfaces;
using AuthorizationManagement.Application.RoleRepositoryMock;

namespace AuthorizationManagement.Application.Implementations
{
    public class RoleManager : IRoleManager
    {
        private readonly IRoleRepositoryMock _roleRepositoryMock;

        public RoleManager(IRoleRepositoryMock roleRepositoryMock)
        {
            _roleRepositoryMock = roleRepositoryMock;
        }

        public async Task CreateRole(RoleDTO newRole)
        {
            var roles = _roleRepositoryMock.GetAllRoles().Result;

            if (newRole != null && roles.SingleOrDefault(role => role.Id == newRole.Id || role.Name == newRole.Name) == null)
            {
                await _roleRepositoryMock.CreateRole(newRole.ToDomain());
            }
        }

        public async Task DeleteRole(int id)
        {
            if (_roleRepositoryMock.GetRole(id) != null)
            {
                await _roleRepositoryMock.DeleteRole(id);
            }
        }

        public async Task<List<RoleDTO>> GetAllRoles()
        {
            return (await _roleRepositoryMock.GetAllRoles()).ToDTO();
        }

        public async Task<RoleDTO?> GetRole(int id)
        {
            var response = await _roleRepositoryMock.GetRole(id);
            return response != null ? response.ToDTO() : null;
        }

        public async Task UpdateRole(RoleDTO role)
        {
            if (role != null && _roleRepositoryMock.GetRole(role.Id) != null)
            {
                await _roleRepositoryMock.UpdateRole(role.ToDomain());
            }           
        }
    }
}
