using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SolutionName.Contracts.Cliente;

public class CreateClienteRequest
{

    [Required(ErrorMessage ="Informe o Nome")]
    [MaxLength(60, ErrorMessage = "Limite de caractéres ultrapassado para o campo")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe o Email")]
    [EmailAddress(ErrorMessage = "Email no formato incorreto")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Informe o MultiplicadorBase")]
    [Range(0, 99.99999)]
    public decimal? MultiplicadorBase { get; set; } 
}