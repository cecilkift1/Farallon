using System;
using Newtonsoft.Json;

namespace Farallon.AlphaVantage
{
    public class AlphaVantageGlobalQuote
    {
        [JsonProperty("01. symbol")]
        public string Symbol { get; set; }

        [JsonProperty("02. open")]
        public string Open { get; set; }

        [JsonProperty("03. high")]
        public string High { get; set; }

        [JsonProperty("04. low")]
        public string Low { get; set; }

        [JsonProperty("05. price")]
        public string Price { get; set; }

        [JsonProperty("06. volume")]
        public long Volume { get; set; }

        [JsonProperty("07. latest trading day")]
        public DateTimeOffset LatestTradingDay { get; set; }

        [JsonProperty("08. previous close")]
        public string PreviousClose { get; set; }

        [JsonProperty("09. change")]
        public string Change { get; set; }

        [JsonProperty("10. change percent")]
        public string ChangePercent { get; set; }
    }
}
