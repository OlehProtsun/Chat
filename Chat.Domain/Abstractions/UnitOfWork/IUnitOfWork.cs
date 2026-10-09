using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.Abstractions.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
