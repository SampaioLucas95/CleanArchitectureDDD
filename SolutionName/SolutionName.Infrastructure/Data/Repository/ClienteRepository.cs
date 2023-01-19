using Microsoft.EntityFrameworkCore;
using SolutionName.Domain.Entities;
using SolutionName.Domain.Repository;
using SolutionName.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Infrastructure.Data.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(EntityframeworkContext dbContext) :base(dbContext)
        {
        }

        public async Task<Cliente> GetByEmail(string email)
        {
            return await _dbSet
                        .Where(p => p.Email == email).FirstOrDefaultAsync();
        }

    }
}
