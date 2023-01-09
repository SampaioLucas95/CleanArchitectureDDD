using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Contracts.Cotacao
{
    public record PatchCotacaoRequest
    (
        decimal? valorCotadoEmReais
        );
}
