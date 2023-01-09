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
        {
            await _unitOfWork.CompleteAsync();
            return new ClienteResult(usuario.Id);
        }
           
        usuario = await _unitOfWork.ClienteRepository.AddAsync(new Domain.Entities.Cliente(nome, email, multiplicadorBase, null, null));
        await _unitOfWork.CompleteAsync();

        return new ClienteResult(usuario.Id);
    }
}