using Chat.DataAccess.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.Entity.Chat
{
    public class MessageEntity
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = null!;
        public DateTime SentAt { get; set; }
        public DateTime? ReviewedOn { get; set; }

        //foreign key
        public Guid SenderId { get; set; }
        public UserEntity Sender { get; set; } = null!;

        //foreign key
        public Guid ChatId { get; set; }
        public ChatEntity Chat { get; set; } = null!;


    }
}
