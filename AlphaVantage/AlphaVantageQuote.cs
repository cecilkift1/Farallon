using Newtonsoft.Json;

namespace Farallon.AlphaVantage
{
    public class AlphaVantageQuote
    {
        [JsonProperty("Global Quote")]
        public AlphaVantageGlobalQuote AlphaVantageGlobalQuote { get; set; }

        public static AlphaVantageQuote FetchGlobalQuote(string ticker)
        {
            var contentJson = AlphaVantageBaseConnection.GetDownloadString("GLOBAL_QUOTE", ticker);
            var currentStockQuote = JsonConvert.DeserializeObject<AlphaVantageQuote>(contentJson);
            return currentStockQuote;
        }
    }
}