using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using SolutionName.Api.Filter;
using SolutionName.Api.Middleware;
using SolutionName.Application;
using SolutionName.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);
{     
    builder.Services.AddCors(opt =>
    {
        opt.AddPolicy(name: "minhaPolicy", builder =>
        {
            builder.AllowAnyOrigin().WithOrigins("https://cotacaomoeda.politesmoke-3558c2dd.eastus.azurecontainerapps.io")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
    });

    builder.Services.AddControllers(config =>
    {
        config.Filters.Add(typeof(ApplicationFilter));
        config.Filters.Add(typeof(ApplicationExceptionFilter));
    });

    builder.Services.AddEndpointsApiExplorer();

    builder.Services
           .AddApplication()
           .AddDataBaseContext(builder.Configuration)
           .AddInfrastructure();

    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api Cotacao - Desafio Backend", Version = "v1" });
    //    c.AddSecurityDefinition("api_key", new OpenApiSecurityScheme
    //    {
    //        Description = "api_key deve aparecer no header da requisição",
    //        Type = SecuritySchemeType.ApiKey,
    //        Name = "api_key",
    //        In = ParameterLocation.Header,
    //        Scheme = "ApiKeyScheme"
    //    });
    //    var key = new OpenApiSecurityScheme()
    //    {
    //        Reference = new OpenApiReference
    //        {
    //            Type = ReferenceType.SecurityScheme,
    //            Id = "api_key"
    //        },
    //        In = ParameterLocation.Header
    //    };
    //    var requirement = new OpenApiSecurityRequirement
    //                {
    //                         { key, new List<string>() }
    //                };
    //    c.AddSecurityRequirement(requirement);

    });
}

var app = builder.Build();
{

    // Configure the HTTP request pipeline.
    //if (app.Environment.IsDevelopment())
    //{
    app.UseSwagger();
    app.UseSwaggerUI();
    //}
    app.MapControllers();
    app.UseHttpsRedirection();
    app.UseRouting();
    app.UseCors("minhaPolicy");
    app.UseAuthentication();
    app.UseAuthorization();
    //app.UseMiddleware<ApiKeyMiddleware>();
    app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
    app.Run();
}

