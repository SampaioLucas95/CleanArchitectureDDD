using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SolutionName.Infrastructure.Context.Cotacao;

namespace SolutionName.Infrastructure;

public static class DependencyInjection{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {        

        return services;
    }

     public static IServiceCollection AddDataBaseContext(this IServiceCollection services, IConfiguration configuration){        

        services.AddDbContext<EntityframeworkContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("dbCotacao")));

        return services;
    }
}