using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using Zerezes.ShortUrl.lib.Models;
using Zerezes.ShortUrl.lib.Settings;
using Zerezes.Lib.Services;

namespace Zerezes.ShortUrl.lib.Services
{
    internal class ShortUrlService : ShortUrlServiceBase, IShortUrlService
    {
        public ShortUrlService(
            ShortUrlSettings settings,
            ILogService log
        ) : base(log, settings)
        {
        }
        
        public async Task<ShortUrlInputOutput> CreateShortURLAsync(ShortUrlInput input)
        {
            var url = $"{_settings.Url}/links";

            try
            {
                return await GetRequestBase(url)
                                .PostJsonAsync(input)
                                .ReceiveJson<ShortUrlInputOutput>();
            }
            catch (FlurlHttpException ex)
            {
                _log.LogWarning($"Error returned from {ex.Call.Request.Url} - StatusCode: {ex.StatusCode} | Errors: {ex.Message}");

                return null;
            }
            catch (Exception ex)
            {
                _log.LogWarning($"Error returned from {url} | Errors: {ex.Message}");

                return null;
            }
        }
    }
}
