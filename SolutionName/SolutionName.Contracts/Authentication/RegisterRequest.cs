namespace SolutionName.Contracts.Authentication;

public record RegisterRequest(
    string Fistname,
    string LastName,
    string Email,
    string Password);
    