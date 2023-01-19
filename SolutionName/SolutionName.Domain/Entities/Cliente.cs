using SolutionName.Domain.Shared;
using static System.Net.Mime.MediaTypeNames;

namespace SolutionName.Domain.Entities
{
    public class Cliente
    {
        public Cliente(string nome, string email, decimal multiplicadorBase)
        {
            Id = Id == Guid.Empty ? Guid.NewGuid() : Id;
            Nome = nome;
            Email = email;
            MultiplicadorBase = multiplicadorBase;

            ValidateEntity();
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public decimal MultiplicadorBase { get; private set; }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
            AssertionConcern.AssertArgumentNotEmpty(Email, "O email não pode estar vazio!");

            AssertionConcern.AssertArgumentLength(Nome, 60, "O nome deve ter até 60 caracteres!");
            AssertionConcern.AssertArgumentLength(Email, 100, "O email deve ter até 100 caracteres!");

            AssertionConcern.AssertArgumentNotEqualZero(MultiplicadorBase, "O multiplicadorBase deve ser maior que 0");
            AssertionConcern.AssertArgumentNotNegative(MultiplicadorBase, "O multiplicadorBase deve ser maior que 0");
        }


    }

}
