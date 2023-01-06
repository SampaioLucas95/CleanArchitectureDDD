using Microsoft.AspNetCore.Mvc;
using SolutionName.Application.Authentication;
using SolutionName.Contracts.Authentication;

namespace SolutionName.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
       var authResult = _authenticationService.Register(request.Fistname, request.LastName, request.Email, request.Password);
       var response = new AuthenticationRequest(authResult.Id,authResult.Fistname, authResult.LastName, authResult.Email, authResult.Token);
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authenticationService.Login(request.Email, request.Password);
        var response = new AuthenticationRequest(authResult.Id,authResult.Fistname, authResult.LastName, authResult.Email, authResult.Token);
        return Ok(request);
    }
}