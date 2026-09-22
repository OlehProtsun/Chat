using Chat.DataAccess.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.Entity.Chat
{
    public class ChatEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();

        public ICollection<MessageEntity> Messages { get; set; } = new List<MessageEntity>();

    }
}
