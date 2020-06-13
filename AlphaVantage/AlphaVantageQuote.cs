using Newtonsoft.Json;

namespace Farallon.AlphaVantage
{
    public class AlphaVantageQuote
    {
        [JsonProperty("Global Quote")]
        public AlphaVantageGlobalQuote AlphaVantageGlobalQuote { get; set; }
    }
}