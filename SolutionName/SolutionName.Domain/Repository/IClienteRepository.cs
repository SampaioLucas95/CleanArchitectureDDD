using SolutionName.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Domain.Repository
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Task<Cliente> GetByEmail(string email);
    }
}
