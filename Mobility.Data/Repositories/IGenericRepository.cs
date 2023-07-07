using Mobility.Data.Models;
using System;
using System.Linq.Expressions;

namespace Mobility.Data.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync(bool isActive, CancellationToken cancellationToken);

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null,
            CancellationToken cancellationToken = default);

        Task<int> AddAsync(T entity, CancellationToken cancellationToken);
        Task<T> GetByIdAsync(int id, CancellationToken cancellationToken);

        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter = null,
            CancellationToken cancellationToken = default);

        Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken);
        Task<bool> HardDeleteByIdAsync(int id, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken);
        Task<bool> ChangeStatusAsync(int id, bool isActive, CancellationToken cancellationToken);
    }
}