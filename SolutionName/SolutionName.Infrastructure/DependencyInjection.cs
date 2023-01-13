using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SolutionName.Application.Cliente;
using SolutionName.Domain.UnitOfWork;
using SolutionName.Infrastructure.Context.Cotacao;

namespace SolutionName.Infrastructure;

public static class DependencyInjection{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, SolutionName.Infrastructure.UnitOfWork.UnitOfWork>();

        return services;
    }

     public static IServiceCollection AddDataBaseContext(this IServiceCollection services, IConfiguration configuration){        

        services.AddDbContext<EntityframeworkContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("dbCotacao"), 
                    sqlServerOptionsAction: sqlOption => 
                        sqlOption.EnableRetryOnFailure(
                            maxRetryCount: 5, 
                            maxRetryDelay: TimeSpan.FromSeconds(30), 
                            errorNumbersToAdd:null)
                        )
                );

        return services;
    }
}