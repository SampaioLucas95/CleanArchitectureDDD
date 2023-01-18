using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using SolutionName.Domain.Entities;
using SolutionName.Domain.Repository;
using SolutionName.Infrastructure.Data.Context;

namespace SolutionName.Infrastructure.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected readonly EntityframeworkContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(EntityframeworkContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }
        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }
       
    }
}