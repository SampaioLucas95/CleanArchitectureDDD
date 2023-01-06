namespace SolutionName.Application.Authentication;

public interface IAuthenticationService{
    AuthenticationResult Login(string email,string password);
    AuthenticationResult Register(string fistname,string lastName,string email,string password);
}