using Newtonsoft.Json;

namespace Farallon.AlphaVantage
{
    public class AlphaVantageBestMatch
    {
        [JsonProperty("1. symbol")]
        public string The1Symbol { get; set; }

        [JsonProperty("2. name")]
        public string The2Name { get; set; }

        [JsonProperty("3. type")]
        public string The3Type { get; set; }

        [JsonProperty("4. region")]
        public string The4Region { get; set; }

        [JsonProperty("5. marketOpen")]
        public string The5MarketOpen { get; set; }

        [JsonProperty("6. marketClose")]
        public string The6MarketClose { get; set; }

        [JsonProperty("7. timezone")]
        public string The7Timezone { get; set; }

        [JsonProperty("8. currency")]
        public string The8Currency { get; set; }

        [JsonProperty("9. matchScore")]
        public string The9MatchScore { get; set; }
    }
}
