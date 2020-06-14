using System;
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
            try
            {
                var bestMatches = JsonConvert.DeserializeObject<AlphaVantageBestMatches>(contentJson);
                return bestMatches;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to deserialize the quote for: {ticker}, {e.Message}");
            }

            return null;
        }
    }
}