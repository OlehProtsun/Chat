using Chat.Domain.Entity.Auth;
using Chat.Domain.Enums.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.ORM.EntityFramework.EntityConfogurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<RolesEntity>
    {
        public void Configure(EntityTypeBuilder<RolesEntity> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.HasData(
                new
                {
                    Id = SystemRoleIds.User,
                    Name = SystemRoles.User
                },
                new
                {
                    Id = SystemRoleIds.Admin,
                    Name = SystemRoles.Admin
                }
            );
        }
    }
}
