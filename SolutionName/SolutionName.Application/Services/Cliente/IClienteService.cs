namespace SolutionName.Application.Cliente;

public interface IClienteService{
    Task<ClienteResult> Create(string nome, string email, decimal multiplicadorBase);
}