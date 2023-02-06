using ElasticSearchHelper.Infrastructure.Services.Interfaces;
using ElasticSearchHelper.Infrastructure.Services.Models;
using Microsoft.Extensions.DependencyInjection;
using Nest;

namespace ElasticSearchHelper.Infrastructure.Extensions
{
    public static class ElasticSearchExtensions
    {
        public static void ConfigureElasticSearch(this IServiceCollection services, ConnectionSettings connectionSettings)
        {
            var settings = connectionSettings;

            settings.ThrowExceptions(alwaysThrow: true);

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);
            services.AddScoped<IElasticSearchService, ElasticSearchService>();
        }
    }
}
