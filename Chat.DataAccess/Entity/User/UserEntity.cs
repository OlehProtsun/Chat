using Chat.DataAccess.Entity.Chat;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.Entity.User
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;

        public ICollection<ChatEntity> Chats { get; set; } = new List<ChatEntity>();

    }
}
