using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// is an example of creating an extension method for modular service registration in ASP.NET Core
namespace Catalog
{
    public static class CatalogModule
    {
        /*
         Extension Method Pattern:
           The this keyword before IServiceCollection services makes this a C# extension method
           It extends the IServiceCollection interface, meaning you can call this method directly on any IServiceCollection object
           The method is named AddCatalogModule suggesting it's meant to register all services related to a catalog feature
         */
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
