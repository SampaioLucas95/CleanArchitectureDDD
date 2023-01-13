
namespace SolutionName.Service.HttpClient.Cotacao
{ 
    public interface ICotacaoHttpClient
    {
         Task<CotacaoResponseClient> GetCotacaoResponseClientAsync();
    }
}
