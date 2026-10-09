using Chat.DataAccess.Abstractions.Repository;
using Chat.DataAccess.Entity.User;
using Chat.DataAccess.ORM.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.Repository
{
    public class UserRepository(ChatDbContext context) : IUserRepository
    {
        public async Task CreateAsync(UserEntity model, CancellationToken cancellationToken = default)
        {
            //....
            await context.User.AddAsync(model, cancellationToken);
        }

        public void Delete(UserEntity model)
        {
            context.User.Remove(model);
        }

        public async Task<List<UserEntity>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await context.User.ToListAsync(cancellationToken);
        }

        public async Task<UserEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await context.User.FirstOrDefaultAsync(u => u.Id == id, cancellationToken);                              
                
        }

        public async Task<UserEntity?> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            return await context.User.FirstOrDefaultAsync(u => u.Name == name, cancellationToken);

        }

        public void Update(UserEntity model)
        {
            context.User.Update(model);
        }
    }
}
