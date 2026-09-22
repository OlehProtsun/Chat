using Chat.DataAccess.Abstractions.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.ORM.EntityFramework
{
    public class UnitOfWork(ChatDbContext context) : IUnitOfWork
    {
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
