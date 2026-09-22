using Chat.DataAccess.Entity.Chat;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.ORM.EntityFramework.EntityConfogurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<MessageEntity>
    {
        public void Configure(EntityTypeBuilder<MessageEntity> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Content)
                .IsRequired();

            builder.HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderId);

            builder.HasOne(m => m.Chat)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.ChatId);
        }
    }
}
