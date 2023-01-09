using SolutionName.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Domain.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IClienteRepository ClienteRepository { get; }

        Task CompleteAsync();
    }
}
