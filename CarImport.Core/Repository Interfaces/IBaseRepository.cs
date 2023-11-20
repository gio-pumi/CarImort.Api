namespace CarImport.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> AddAsync(T item);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<List<T>> UpdateAsync(T item);
        Task<List<T>> DeleteAsync(int id);

    }
}
