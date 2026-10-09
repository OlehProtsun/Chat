using Chat.DataAccess.Entity.Chat;
using Chat.DataAccess.Entity.User;
using Chat.DataAccess.ORM.EntityFramework.EntityConfogurations;
using Chat.Domain.Entity.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.ORM.EntityFramework
{
    public class ChatDbContext(DbContextOptions<ChatDbContext> options) : DbContext(options)
    {
        public DbSet<UserEntity> User { get; set; }
        public DbSet<ChatEntity> Chat { get; set; }
        public DbSet<MessageEntity> Message { get; set; }
        public DbSet<RolesEntity> Role { get; set; }
        public DbSet<RolesUsersEntity> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ChatDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
