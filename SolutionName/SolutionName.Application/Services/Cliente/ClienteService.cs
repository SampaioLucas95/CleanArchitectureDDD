using SolutionName.Application.Services.Cliente;
using SolutionName.Application.Services.Cliente.Results;
using SolutionName.Domain.UnitOfWork;
using SolutionName.Service.HttpClient.Cotacao;

namespace SolutionName.Application.Cliente;

public class ClienteService : IClienteService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICotacaoHttpClient _cotacaoHttpClient;
    public ClienteService(IUnitOfWork unitOfWork, ICotacaoHttpClient cotacaoHttpClient)
    {
        _unitOfWork = unitOfWork;
        _cotacaoHttpClient = cotacaoHttpClient;
    }
    public async Task<PostClienteResult> Create(string nome, string email, decimal multiplicadorBase)
    {        
        var usuario = await _unitOfWork.ClienteRepository.GetByEmail(email);
        if (usuario != null)
            return new PostClienteResult(Guid.Empty);
        
        usuario = new Domain.Entities.Cliente(nome, email, multiplicadorBase);
        
        await _unitOfWork.ClienteRepository.AddAsync(usuario);
        await _unitOfWork.CompleteAsync();

        return new PostClienteResult(usuario.Id);
    }

    public async Task<GetCotacaoResult> GetById(Guid id)
    {
        var cliente = await _unitOfWork.ClienteRepository.GetByIdAsync(id);

        if (cliente != null)
        {
           var dolarCotado = await _cotacaoHttpClient.GetCotacaoResponseClientAsync();

            return new GetCotacaoResult(Convert.ToDecimal(dolarCotado.bid), CalcularCotacaoComTaxa(Convert.ToDecimal(dolarCotado.bid), cliente.MultiplicadorBase));
        }
        return new GetCotacaoResult(null, null);
    }

    public async Task<PatchCotacaoResult> Patch(Guid id, decimal valorCotadoEmReais)
    {
        var cliente = await _unitOfWork.ClienteRepository.GetByIdAsync(id);

        if (cliente == null)
            return new PatchCotacaoResult("","",Guid.Empty,null,null,null);

            var dolarCotado = await _cotacaoHttpClient.GetCotacaoResponseClientAsync();
            decimal dolarCotadoByReais = ObterDolarByReal(dolarCotado.bid, valorCotadoEmReais);

            return new PatchCotacaoResult(cliente.Nome, cliente.Email, cliente.Id, valorCotadoEmReais, dolarCotadoByReais, CalcularCotacaoComTaxa(dolarCotadoByReais, cliente.MultiplicadorBase));
    }

    private decimal CalcularCotacaoComTaxa(decimal dolarCotado, decimal multiplicadorBase)
    {
        return Convert.ToDecimal(dolarCotado) * multiplicadorBase;
    }

    private decimal ObterDolarByReal(string dolarCotado, decimal valorEmReaisParaCotacao)
    {
        return valorEmReaisParaCotacao / Convert.ToDecimal(dolarCotado);
    }
}