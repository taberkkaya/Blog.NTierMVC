using Blog.NTierMVC.Service.Service.Abstractions;
using Blog.NTierMVC.Service.Service.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Blog.NTierMVC.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService,ArticleService>();

            services.AddScoped<ICategoryService,CategoryService>();

            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
