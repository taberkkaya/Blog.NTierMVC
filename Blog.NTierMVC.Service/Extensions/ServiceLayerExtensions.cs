using Blog.NTierMVC.Service.Service.Abstractions;
using Blog.NTierMVC.Service.Service.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.NTierMVC.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService,ArticleService>();

            return services;
        }
    }
}
