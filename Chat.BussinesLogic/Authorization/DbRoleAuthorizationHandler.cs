using Chat.BussinesLogic.Enums.Auth;
using Chat.Domain.Abstractions.Repository;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Chat.BussinesLogic.Authorization
{
    public sealed class DbRoleAuthorizationHandler(
        IUserRoleRepository userRoleRepository) : AuthorizationHandler<DbRoleRequirement>
    {
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, DbRoleRequirement requirement)
        {
            // 1. Check authentication
            if (context.User.Identity?.IsAuthenticated != true)
                return;

            // 2. Get user ID from JWT
            var userIdClaim = context.User.FindFirst(CustomClaimTypes.UserId)?.Value;

            if (!Guid.TryParse(userIdClaim, out var userId))
                return;

            // 3. Check role in database
            bool hasRole = await userRoleRepository.HasRoleAsync(
                userId,
                requirement.Role);

            // 4. Grant access
            if (hasRole)
            {
                context.Succeed(requirement);
            }
        }
    }
}
