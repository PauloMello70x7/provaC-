using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using ProvaProver.DomainModel.Interfaces.Repositories;
using ProvaProver.DomainModel.Interfaces.Services;
using ProvaProver.DomainModel.Interfaces.UoW;
using ProvaProver.DomainService;
using ProvaProver.Infra.Context;
using ProvaProver.Infra.Repository;
using ProvaProver.Infra.UoW;

namespace ProvaProver.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ProvaProverContext>();

            // Unit Of Work
            services.AddScoped<IUnitOfWork, EntityFrameworkUnitOfWork>();


            //Swagger
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

         
            // Contato
            services.AddScoped<IContatoRepository, ContatoRepository>();
            services.AddScoped<IContatoService, ContatoService>();
            
            return services;
        }
    }
}

