using SolutionName.Application.Services.Cliente;
using SolutionName.Application.Services.Cliente.Results;

namespace SolutionName.Application.Cliente;

public interface IClienteService{
    Task<PostClienteResult> Create(string nome, string email, decimal multiplicadorBase);
    Task<GetCotacaoResult> GetById(Guid id);

    Task<PatchCotacaoResult> Patch(Guid id, decimal valorCotadoEmReais);
}