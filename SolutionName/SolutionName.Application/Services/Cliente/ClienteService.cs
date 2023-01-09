using SolutionName.Application.Services.Cliente;
using SolutionName.Application.Services.Cliente.Results;
using SolutionName.Domain.UnitOfWork;
using System;

namespace SolutionName.Application.Cliente;

public class ClienteService : IClienteService
{
    private readonly IUnitOfWork _unitOfWork;
    public ClienteService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<ClienteResult> Create(string nome, string email, decimal multiplicadorBase)
    {        
        var usuario = await _unitOfWork.ClienteRepository.GetByEmail(email);
        if (usuario != null)
            return new ClienteResult(usuario.Id);
        

        usuario = new Domain.Entities.Cliente(nome, email, multiplicadorBase, null, null);
        
        await _unitOfWork.ClienteRepository.AddAsync(usuario);
        await _unitOfWork.CompleteAsync();

        return new ClienteResult(usuario.Id);
    }

    public async Task<GetCotacaoResult> GetById(Guid id)
    {
        var cliente = await _unitOfWork.ClienteRepository.GetByIdAsync(id);

        return new GetCotacaoResult(cliente.ValorComTaxa, cliente.ValorOriginal);
    }

    public async Task<PatchCotacaoResult> Patch(Guid id, decimal? valorCotadoEmReais)
    {
        var cliente = await _unitOfWork.ClienteRepository.GetByIdAsync(id);

        //realizar cotacao


        //

        return new PatchCotacaoResult(cliente.Nome, cliente.Email,cliente.Id ,cliente.ValorCotadoEmReais, cliente.ValorComTaxa, cliente.ValorOriginal);
    }
}