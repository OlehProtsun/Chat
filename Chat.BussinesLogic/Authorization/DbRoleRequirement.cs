using Microsoft.AspNetCore.Authorization;

namespace Chat.BussinesLogic.Authorization
{
    public sealed record DbRoleRequirement(string Role)
        : IAuthorizationRequirement;
}
