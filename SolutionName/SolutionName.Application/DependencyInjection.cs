using Microsoft.Extensions.DependencyInjection;
using SolutionName.Application.Cliente;

namespace SolutionName.Application;

public static class DependencyInjection{
    public static IServiceCollection AddApplication(this IServiceCollection services){
        services.AddScoped<IClienteService,ClienteService>();

        return services;
    }
}