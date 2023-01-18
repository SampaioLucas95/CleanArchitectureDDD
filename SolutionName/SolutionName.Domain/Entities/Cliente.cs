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
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public decimal MultiplicadorBase { get; private set; }
    }

}
