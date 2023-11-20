using CarImport.Core.Interfaces;
using CarImport.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarImport.Core.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

        public BaseRepository(ApplicationDbContext context)
        {
            _db = context;
        }

        #region Async Methods

        public virtual async Task<List<T>> AddAsync(T item)
        {
            _db.Set<T>().Add(item);
            await _db.SaveChangesAsync();
            List<T> query = await _db.Set<T>().AsNoTracking().ToListAsync();

            return query;
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            List<T> query = await _db.Set<T>().AsNoTracking().ToListAsync();
            return query;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            T item = await _db.Set<T>().FindAsync(id);
            return item;
        }

        public virtual async Task<List<T>> UpdateAsync(T item)
        {

            _db.Entry(item).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            List<T> query = await _db.Set<T>().AsNoTracking().ToListAsync();

            return query;
        }

        public virtual async Task<List<T>> DeleteAsync(int id)
        {
            T itemToDelete = await _db.Set<T>().FindAsync(id);
            _db.Set<T>().Remove(itemToDelete);
            await _db.SaveChangesAsync();
            List<T> query = await _db.Set<T>().AsNoTracking().ToListAsync();

            return query;
        }

        #endregion
    }
}
