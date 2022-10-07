using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using Zerezes.Lib.Services;
using Zerezes.ShortUrl.lib.Settings;

namespace Zerezes.ShortUrl.lib.Services
{
    internal class ShortUrlServiceBase
    {
        protected readonly ILogService _log;
        protected readonly ShortUrlSettings _settings;

        public ShortUrlServiceBase(ILogService log, ShortUrlSettings settings)
        {
            _log = log;
            _settings = settings;
        }

        protected IFlurlRequest GetRequestBase(string url) => url
                    .WithHeader("Authorization", _settings.SecretKey)
                    .ConfigureRequest(settings =>
                    {
                        var jsonSettings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            ObjectCreationHandling = ObjectCreationHandling.Replace
                        };
                        settings.JsonSerializer = new NewtonsoftJsonSerializer(jsonSettings);
                    });
    }
}