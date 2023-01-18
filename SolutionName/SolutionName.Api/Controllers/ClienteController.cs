using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using SolutionName.Application.Cliente;
using SolutionName.Application.Services.Cliente;
using SolutionName.Contracts.Cliente;
using SolutionName.Contracts.Cotacao;

namespace SolutionName.Api.Controllers;

[ApiController]
[Route("api/v1/cliente")]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _ClienteService;
    public ClienteController(IClienteService ClienteService)
    {
        _ClienteService = ClienteService;
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateClienteRequest request)
    {

       var result = await _ClienteService.Create(request.Nome, request.Email, Convert.ToDecimal(request.MultiplicadorBase));
       var response = new CreateClienteResponse(result.Id);

        return Ok(response);
    }

    [HttpGet]
    [Route("/{id}/cotacao")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _ClienteService.GetById(id);
        var response = new GetCotacaoResponse(result.valorOriginal, result.valorComTaxa);
        return Ok(response);
    }

    [HttpPatch]
    [Route("/{id}/cotacao")]
    public async Task<IActionResult> Patch(Guid id,[FromBody] PatchCotacaoRequest request)
    {
        var result = await _ClienteService.Patch(id, Convert.ToDecimal(request.valorCotadoEmReais));

        var response = new PatchCotacaoResponse(
            new PatchClienteResponse(result.nome, result.email, result.id),
            result.valorCotadoEmReais,
            result.valorOriginal,
            result.valorComTaxa);

        return Ok(response);
    }

}