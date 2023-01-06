using Microsoft.Extensions.DependencyInjection;
using SolutionName.Application.Authentication;

namespace SolutionName.Application;

public static class DependencyInjection{
    public static IServiceCollection AddApplication(this IServiceCollection services){
        services.AddScoped<IAuthenticationService,AuthenticationService>();

        return services;
    }
}