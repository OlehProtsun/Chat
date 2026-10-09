using Chat.DataAccess.Abstractions.Repository;
using Chat.DataAccess.ORM.EntityFramework;
using Chat.Domain.Abstractions.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.Repository
{
    public class UserRoleRepository(ChatDbContext context) : IUserRoleRepository
    {
        public async Task<bool> HasRoleAsync(Guid userId, string roleName)
        {
            return await context.UserRoles
                .AsNoTracking()
                .AnyAsync(x =>
                    x.UserId == userId &&
                    x.Role.Name == roleName);

        }
    }
}
