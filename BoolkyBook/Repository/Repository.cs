using System.Linq.Expressions;
using BoolkyBook.Data;
using BoolkyBook.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BoolkyBook.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    
    private readonly ApplicationDbContext _db;
    internal DbSet<T> dbSet;
    public Repository(ApplicationDbContext db)
    {
        _db = db;
        //_db.Products.Include(u => u.Category).Include(u=>u.CoverType);
        this.dbSet = _db.Set<T>();
    }

    public T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null,string? includeProperties = null,bool tracked = true)
    {
        IQueryable<T> query;
        if (tracked)
        {
            query = dbSet;
        }
        else
        {
            query = dbSet.AsNoTracking();
        }
        query = query.Where(filter);
        if (includeProperties != null)
        {
            foreach(var includeProp in includeProperties.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }
        return query.FirstOrDefault();
    }

    public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter,string? includeProperties = null)
    {
        IQueryable<T> query = dbSet;
        if (filter != null)
        {
            query = query.Where(filter);
        }
        
        if (includeProperties != null)
        {
            foreach(var includeProp in includeProperties.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }
        return query.ToList();
    }

    public void Add(T entity)
    {
        dbSet.Add(entity);
    }

    public void Remove(T entity)
    {
        dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entity)
    {
        dbSet.RemoveRange(entity);
    }
}