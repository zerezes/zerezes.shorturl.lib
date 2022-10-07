using Newtonsoft.Json;

namespace Zerezes.ShortUrl.lib.Models
{
    public class ShortUrlInput
    {
        [JsonProperty("allowDuplicates")]
        public bool AllowDuplicates { get; set; }

        [JsonProperty("expiresAt")]
        public long? ExpiresAt { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("originalURL")]
        public string OriginalURL { get; set; }

        [JsonProperty("utmSource")]
        public string UtmSource { get; set; }

        [JsonProperty("utmMedium")]
        public string UtmMedium { get; set; }

        [JsonProperty("utmCampaign")]
        public string UtmCampaign { get; set; }
    }
}