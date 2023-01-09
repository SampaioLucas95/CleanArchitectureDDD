using SolutionName.Application;
using SolutionName.Infrastructure;
using SolutionName.Infrastructure.Context.Cotacao;

var builder = WebApplication.CreateBuilder(args);
{


    builder.Services
                .AddApplication()
                .AddDataBaseContext(builder.Configuration)
                .AddInfrastructure();

    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

