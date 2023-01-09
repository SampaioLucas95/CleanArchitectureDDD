using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Application.Services.Cliente
{
    public record GetCotacaoResult
    (
         decimal? valorOriginal,
         decimal? valorComTaxa
    );
}
