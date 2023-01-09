
using System.Linq.Expressions;

namespace SolutionName.Domain.Repository;
public interface IBaseRepository<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task<T> GetByIdAsync(Guid id);    
}