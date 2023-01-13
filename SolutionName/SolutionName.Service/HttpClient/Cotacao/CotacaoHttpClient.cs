
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
            var cotacao = new CotacaoResponseClient();
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                
            }

            cotacao = JsonConvert.DeserializeObject<CotacaoResponseClient>(responseString);

            return cotacao;
        }
    }
}
