namespace SolutionName.Application.Authentication;

public record AuthenticationResult(
    Guid Id,
    string Fistname,
    string LastName,
    string Email,
    string Token
);