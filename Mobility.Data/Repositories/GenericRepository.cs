using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Mobility.Data.Context;
using Mobility.Data.Models;

namespace Mobility.Data.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private MobilityContext _context;

    public GenericRepository(MobilityContext context)
    {
        _context = context;
    }

    public virtual async Task<int> AddAsync(T entity, CancellationToken cancellationToken)
    {
        await _context.AddAsync(entity, cancellationToken);
        var id = await _context.SaveChangesAsync(cancellationToken);
        return id;
    }

    public virtual async Task<bool> DeleteByIdAsync(int id, CancellationToken cancellationToken)
    {
        var entity = await _context.Set<T>().FirstOrDefaultAsync(a => a.Id.Equals(id), cancellationToken);
        if (entity == null)
            return false;
        entity.IsActive = false;
        entity.ModifiedDate = DateTime.Now;
        _context.Update(entity);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public virtual async Task<bool> HardDeleteByIdAsync(int id, CancellationToken cancellationToken)
    {
        var entity = await _context.Set<T>().FirstOrDefaultAsync(a => a.Id.Equals(id), cancellationToken);
        if (entity == null)
            return false;
        _context.Remove(entity);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public virtual async Task<List<T>> GetAllAsync(bool isActive, CancellationToken cancellationToken)
    {
        var result = await _context.Set<T>().Where(a => a.IsActive == isActive).ToListAsync(cancellationToken);
        return result;
    }

    public virtual async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null,
        CancellationToken cancellationToken = default)
    {
        return filter == null
            ? await _context.Set<T>().ToListAsync(cancellationToken)
            : await _context.Set<T>().Where(filter).ToListAsync(cancellationToken);
    }

    public virtual async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter = null,
        CancellationToken cancellationToken = default)
    {
        return await _context.Set<T>().SingleOrDefaultAsync(filter, cancellationToken);
    }

    public virtual async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _context.Set<T>().SingleOrDefaultAsync(a => a.Id.Equals(id), cancellationToken);
    }

    public virtual async Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken)
    {
        _context.Entry<T>(entity).State = EntityState.Modified;
        entity.ModifiedDate = DateTime.Now;
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public virtual async Task<bool> ChangeStatusAsync(int id, bool isActive, CancellationToken cancellationToken)
    {
        var entity = await _context.Set<T>().SingleOrDefaultAsync(a => a.Id.Equals(id), cancellationToken);
        entity.ModifiedDate = DateTime.Now;
        entity.IsActive = isActive;
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}