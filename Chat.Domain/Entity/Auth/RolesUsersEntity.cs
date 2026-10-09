using Chat.DataAccess.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Domain.Entity.Auth
{
    public class RolesUsersEntity
    {
        public Guid UserId { get; set; }
        public UserEntity User { get; set; } = null!;
        public Guid RoleId { get; set; }
        public RolesEntity Role { get; set; } = null!;
    }
}
