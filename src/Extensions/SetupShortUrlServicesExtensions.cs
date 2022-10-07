using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Zerezes.ShortUrl.lib.Services;
using Zerezes.ShortUrl.lib.Settings;

namespace Zerezes.ShortUrl.lib.Extensions
{
    public static class SetupShortUrlServicesExtensions
    {
        public static IServiceCollection SetupShortUrlServices(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration?.GetSection("ShortUrl").Get<ShortUrlSettings>();

            services.AddSingleton(settings);

            services.AddSingleton<IShortUrlService, ShortUrlService>();

            return services;
        }
    }
}
