using Microsoft.AspNetCore.Mvc;
using SolutionName.Application.Cliente;
using SolutionName.Contracts.Cliente;

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
    public IActionResult Create(ClienteRequest request)
    {
       var authResult = _ClienteService.Create(request.Nome, request.Email, request.MultiplicadorBase);
       var response = new ClienteResponse(authResult.Id);
        return Ok(response);
    }

}