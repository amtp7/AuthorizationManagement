using Grpc.Net.Client;
using static GrpcClient.RoleAuthorization;
using static GrpcClient.RoleManagement;

namespace GrpcClient
{
    public class Client : IDisposable
    {
        private readonly GrpcChannel channel;
        private readonly RoleManagementClient managementClient;
        private readonly RoleAuthorizationClient authorizationClient;

        public Client()
        {
            channel = GrpcChannel.ForAddress("https://localhost:7231");
            managementClient = new RoleManagementClient(channel);
            authorizationClient = new RoleAuthorizationClient(channel);
        }

        public async Task<CreateRoleResponse> CreateRoleAsync(int roleId, string roleName)
        {
            var response = await managementClient.CreateRoleAsync(new CreateRoleRequest { RoleId = roleId, RoleName = roleName });
            channel.Dispose();
            return response;
        }

        public async Task<GetAllRolesResponse> GetAllRolesAsync()
        {
            var response = await managementClient.GetAllRolesAsync(new Empty());
            channel.Dispose();
            return response;
        }

        public async Task<GetRoleResponse> GetRoleAsync(int roleId)
        {
            var response = await managementClient.GetRoleAsync(new GetRoleRequest { RoleId = roleId });
            channel.Dispose();
            return response;
        }

        public async Task<AuthorizeRolesResponse> AuthorizeRolesAsync(int[] roleIds)
        {
            var request = new AuthorizeRolesRequest();
            request.RoleIds.Add(roleIds);
            var response = await authorizationClient.AuthorizeRolesAsync(request);
            channel.Dispose();
            return response;
        }

        public void Dispose()
        {
            channel.ShutdownAsync().Wait();
        }
    }
}