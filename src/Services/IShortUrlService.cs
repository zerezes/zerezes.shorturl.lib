using Zerezes.ShortUrl.lib.Models;

namespace Zerezes.ShortUrl.lib.Services
{
    public interface IShortUrlService
    {
        Task<ShortUrlInputOutput> CreateShortURLAsync(ShortUrlInput input);
    }
}
