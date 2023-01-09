namespace SolutionName.Contracts.Cliente;

public record CreateClienteRequest(
    Guid Id,
    string Nome,
    string Email,
    decimal MultiplicadorBase);