using System;
using System.Linq.Expressions;
using Web.Models.Commons;

namespace Web.Repositories;

public interface IRepository<T> where T : Auditable
{
    IQueryable<T> GetAll(Expression<Func<T, bool>> expression, string[] includes = null, bool isTracking = true);
    ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, bool isTracking = true, string[] includes = null);
    ValueTask<T> CreateAsync(T entity);
    ValueTask<bool> DeleteAsync(long id);
    T Update(T entity);
    ValueTask SaveChangesAsync();
}
