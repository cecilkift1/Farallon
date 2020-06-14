using System;
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
            try
            {
                var currentStockQuote = JsonConvert.DeserializeObject<AlphaVantageQuote>(contentJson);
                return currentStockQuote;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to deserialize the quote for: {ticker}, {e.Message}");
            }

            return null;
        }
    }
}