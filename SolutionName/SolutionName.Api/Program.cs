using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using SolutionName.Api.Filter;
using SolutionName.Application;
using SolutionName.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);
{


    builder.Services
                .AddApplication()
                .AddDataBaseContext(builder.Configuration)
                .AddInfrastructure();

    builder.Services.AddControllers(config =>
    {
        config.EnableEndpointRouting = false;
        config.Filters.Add(typeof(ApplicationFilter));
        config.Filters.Add(typeof(ApplicationExceptionFilter));
    });

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

}

var app = builder.Build();
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

