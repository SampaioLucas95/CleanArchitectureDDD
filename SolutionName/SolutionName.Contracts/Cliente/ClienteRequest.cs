namespace SolutionName.Contracts.Cliente;

public record ClienteRequest(
    Guid Id,
    string Nome,
    string Email,
    decimal MultiplicadorBase);