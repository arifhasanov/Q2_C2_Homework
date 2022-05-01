namespace Homework.Data.Services;

public interface IService<T, T2>
{
    Task<List<T>> Create(T2 item);
    Task<T> Update(int id, T2 item);
    Task Delete(int id);
    Task<T> Get(int id);
    Task<IList<T>> GetAll();
}
