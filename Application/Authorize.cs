using AuthorizationManagement.Application.DTOs;
using AuthorizationManagement.Application.Interfaces;

namespace Application
{
    public class Authorize : IAuthorize
    {
        public bool IsAuthorized(List<RoleDto> roles)
        {
            return true;
        }
    }
}
