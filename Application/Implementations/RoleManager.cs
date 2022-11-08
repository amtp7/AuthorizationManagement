using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.Application.Interfaces;
using AuthorizationManagement.Application.Mappers;

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
            var user = _roleRepositoryMock.GetRole(newRole.Id).Result;

            if (user == null)
            {
                return await _roleRepositoryMock.CreateRole(newRole.ToDomain());
            }
            return -1;
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