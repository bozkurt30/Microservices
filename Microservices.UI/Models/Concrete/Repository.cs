using Microservices.UI.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Microservices.UI.Models.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await _context.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await _context.AddRangeAsync(datas);
            return true;
        }

        public IQueryable<T> GetAll() => (IQueryable<T>)_context.Companies.ToList();


        public Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = _context.Remove(model);
            return entityEntry.State != EntityState.Deleted;
        }


        public bool RemoveRange(List<T> datas)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

        public bool Update(T model)
        {
            EntityEntry entityEntry = _context.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}
