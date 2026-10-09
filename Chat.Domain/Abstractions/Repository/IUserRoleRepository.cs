using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Domain.Abstractions.Repository
{
    public interface IUserRoleRepository
    {
        Task<bool> HasRoleAsync(Guid userId, string roleName);
    }
}
