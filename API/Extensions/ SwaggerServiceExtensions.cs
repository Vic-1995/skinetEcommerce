using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class  SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
             services.AddSwaggerGen(c =>
            {
                        c.SwaggerDoc("vl", new OpenApiInfo { Title = "skinetEcommerce API", Version = "v1"});
                });

                return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
                app.UseSwaggerUI(c => c
                .SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));


        return app;
        }
    }
}