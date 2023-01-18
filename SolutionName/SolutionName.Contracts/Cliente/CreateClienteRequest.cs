using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SolutionName.Contracts.Cliente;

public class CreateClienteRequest
{
    public Guid Id { get; set; }

    [Required(ErrorMessage ="Informe o Nome")]
    [MaxLength(60, ErrorMessage = "Limite de caract�res ultrapassado para o campo")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe o Email")]
    [EmailAddress(ErrorMessage = "Email no formato incorreto")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Informe o MultiplicadorBase")]
    [Range(0, 9999999999999999.99)]
    public decimal? MultiplicadorBase { get; set; } 
}