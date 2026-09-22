using Chat.DataAccess.Entity.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.ORM.EntityFramework.EntityConfogurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .IsRequired();

            builder.Property(u => u.PasswordHash)
                .IsRequired();

            builder.HasMany(u => u.Chats)
                .WithMany(u => u.Users);

        }
    }
}
