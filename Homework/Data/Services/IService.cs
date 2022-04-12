namespace Homework.Data.Services;

public interface IService<T>
{
    Task Create(T item);
    Task<T> Update(int id, T item);
    Task Delete(int id);
    Task<T> Get(int id);
    Task<IList<T>> GetAll();
}
