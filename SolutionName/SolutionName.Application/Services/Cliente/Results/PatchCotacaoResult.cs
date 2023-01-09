using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Application.Services.Cliente.Results
{
    public record PatchCotacaoResult
    (
        string nome,
        string email,
        Guid id,
        decimal? valorCotadoEmReais,
        decimal? valorOriginal,
        decimal? valorComTaxa);
}
