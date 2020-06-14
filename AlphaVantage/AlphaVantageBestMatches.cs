using Newtonsoft.Json;

namespace Farallon.AlphaVantage
{
    public class AlphaVantageBestMatches
    {
        [JsonProperty("bestMatches")]
        public AlphaVantageBestMatch[] BestMatches { get; set; }

        public AlphaVantageBestMatches Search(string ticker)
        {
            var contentJson = AlphaVantageBaseConnection.GetDownloadString("SYMBOL_SEARCH", ticker);
            var bestMatches = JsonConvert.DeserializeObject<AlphaVantageBestMatches>(contentJson);
            return bestMatches;
        }
    }
}