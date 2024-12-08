using MarcasAut.Core.Entities;
using System.Linq.Expressions;

namespace MarcasAut.Core.Interfaces
{
  //Metodos del repositorio generico
  public interface IBaseRepository<T> where T : BaseEntity
  {
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T entity);
    void Update(T entity);
    Task DeleteAsync(int id);
    Task<T?> FindAsync(Expression<Func<T, bool>> predicate);
  }
}
