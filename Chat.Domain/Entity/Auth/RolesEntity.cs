using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Domain.Entity.Auth
{
    public class RolesEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<RolesUsersEntity> UserRoles = new List<RolesUsersEntity>();

    }
}
