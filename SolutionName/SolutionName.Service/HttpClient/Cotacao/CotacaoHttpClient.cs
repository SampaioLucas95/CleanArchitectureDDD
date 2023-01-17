
using Newtonsoft.Json;

namespace SolutionName.Service.HttpClient.Cotacao
{
    public  class CotacaoHttpClient : ICotacaoHttpClient
    {
        public readonly System.Net.Http.HttpClient _httpClient;
        public CotacaoHttpClient(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CotacaoResponseClient> GetCotacaoResponseClientAsync()
        {
            var response = await _httpClient.GetAsync("https://economia.awesomeapi.com.br/json/last/USD");
            var cotacao = new Root();
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                
            }

            cotacao = JsonConvert.DeserializeObject<SolutionName.Service.HttpClient.Cotacao.Root>(responseString);

            return cotacao?.USDBRL;
        } 
    }
}
