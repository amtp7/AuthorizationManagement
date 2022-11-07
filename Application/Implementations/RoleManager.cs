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

        public async Task<int> CreateRole(RoleDTO newRole)
        {
            var roles = _roleRepositoryMock.GetAllRoles().Result;

            if (newRole != null && roles.SingleOrDefault(role => role.Id == newRole.Id || role.Name == newRole.Name) == null)
            {
                await _roleRepositoryMock.CreateRole(newRole.ToDomain());
            }
            return (await _roleRepositoryMock.GetRole(newRole.Id)).Id;
        }

        public async Task<IEnumerable<RoleDTO?>> GetAllRoles()
        {
            var result = await _roleRepositoryMock.GetAllRoles();
            return result.ToDTO();
        }

        public async Task<RoleDTO?> GetRole(int id)
        {
            var result = await _roleRepositoryMock.GetRole(id);
            return result.ToDTO();
        }
    }
}