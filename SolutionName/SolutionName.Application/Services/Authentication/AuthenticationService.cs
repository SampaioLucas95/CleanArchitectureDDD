namespace SolutionName.Application.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(),"fistname","lastName",email,"token");
    }

    public AuthenticationResult Register(string fistname, string lastName, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(),fistname,lastName,email,"token");
    }
}