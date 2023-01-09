namespace SolutionName.Domain.Entities
{
    public class Cliente
    {
        public Cliente(string nome, string email, decimal multiplicadorBase, decimal? valorCotadoEmReais, decimal? valorOriginal)
        {
            Id = Id == Guid.Empty ? Guid.NewGuid() : Id;
            Nome = nome;
            Email = email;
            MultiplicadorBase = multiplicadorBase;
            setValorCotacao(valorCotadoEmReais, valorOriginal);
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public decimal MultiplicadorBase { get; private set; }
        public decimal? ValorCotadoEmReais { get; set; }
        public decimal? ValorOriginal { get; set; }
        public decimal? ValorComTaxa { get; set; }

        public void setValorCotacao(decimal? valorCotadoEmReais, decimal? valorOriginal)
        {
            ValorCotadoEmReais = valorCotadoEmReais;
            ValorOriginal = valorOriginal;
            ValorComTaxa = (MultiplicadorBase * valorOriginal);
        }

    }

}
