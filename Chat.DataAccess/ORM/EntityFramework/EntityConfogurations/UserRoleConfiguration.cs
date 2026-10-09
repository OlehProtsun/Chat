using Chat.Domain.Entity.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.ORM.EntityFramework.EntityConfogurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<RolesUsersEntity>
    {
        public void Configure(EntityTypeBuilder<RolesUsersEntity> builder)
        {
            builder.ToTable("UserRoles");

            builder.HasKey(x => new
            {
                x.UserId,
                x.RoleId
            });

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Role)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(x => x.RoleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
    
}
