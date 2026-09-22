using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.Abstractions.Repository
{
    public interface IBaseRepository<T> where T: class
    {
        Task CreateAsync(T model, CancellationToken cancellationToken = default);
        void Update(T model);
        void Delete(T model);
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
