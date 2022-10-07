using Newtonsoft.Json;

namespace Zerezes.ShortUrl.lib.Models
{
    public class ShortUrlInputOutput
    {
        [JsonProperty("lcpath")]
        public string Lcpath { get; set; }
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("DomainId")]
        public int? DomainId { get; set; }
        [JsonProperty("archived")]
        public bool? Archived { get; set; }
        [JsonProperty("OwnerId")]
        public int? OwnerId { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        [JsonProperty("originalURL")]
        public string OriginalURL { get; set; }
        [JsonProperty("cloaking")]
        public bool? Cloaking { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("idString")]
        public string IdString { get; set; }
        [JsonProperty("tags")]
        public List<object> Tags { get; set; }
        [JsonProperty("shortURL")]
        public string ShortURL { get; set; }
        [JsonProperty("secureShortURL")]
        public string SecureShortURL { get; set; }
        [JsonProperty("duplicate")]
        public bool? Duplicate { get; set; }
    }
}