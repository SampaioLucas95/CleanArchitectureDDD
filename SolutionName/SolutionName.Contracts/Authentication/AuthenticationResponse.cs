namespace SolutionName.Contracts.Authentication;

public record AuthenticationRequest(
    Guid Id,
    string Fistname,
    string LastName,
    string Email,
    string Token);
    