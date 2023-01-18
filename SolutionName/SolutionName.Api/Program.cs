using Microsoft.Extensions.DependencyInjection;
using SolutionName.Application;
using SolutionName.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);
{


    builder.Services
                .AddApplication()
                .AddDataBaseContext(builder.Configuration)
                .AddInfrastructure();

    builder.Services.AddControllers();

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

