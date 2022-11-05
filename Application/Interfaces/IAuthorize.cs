using AuthorizationManagement.Application.DTOs;

namespace AuthorizationManagement.Application.Interfaces
{
    public interface IAuthorize
    {
        public bool IsAuthorized(List<RoleDto> roles);
    }
}
