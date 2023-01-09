using SolutionName.Contracts.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Contracts.Cotacao
{
    public record PatchCotacaoResponse
    (
        PatchClienteResponse cliente,
        decimal? valorCotadoEmReais,
        decimal? valorOriginal,
        decimal? valorComTaxa
    );
}
