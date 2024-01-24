namespace HotelListing.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T item);
        Task DeleteAsync(int id);
        Task UpdateAsync(T item);
        Task<bool> Exists(int id);
    }
}
