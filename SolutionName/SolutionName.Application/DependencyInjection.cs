using Microsoft.Extensions.DependencyInjection;
using SolutionName.Application.Cliente;
using SolutionName.Service.HttpClient.Cotacao;
using System.Net.Http;

namespace SolutionName.Application;

public static class DependencyInjection{
    public static IServiceCollection AddApplication(this IServiceCollection services){
        services.AddScoped<IClienteService,ClienteService>();      
        services.AddScoped<ICotacaoHttpClient>(p => new CotacaoHttpClient(new HttpClient()));


        return services;
    }
}