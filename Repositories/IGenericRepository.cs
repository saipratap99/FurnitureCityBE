namespace FurnitureCityBE.Repositories;

public interface IGenericRepository<T>  where T : class
{
    Task<List<T>> GetAll();
    Task<T?> GetById(Guid id);
    void Add(T entity);
    void Edit(T entity);
    void Del(Guid id);
    Task<int> Savechange();
}
