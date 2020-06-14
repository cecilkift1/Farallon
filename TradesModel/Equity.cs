using System;
using System.Linq;
using Farallon.AlphaVantage;
using Farallon.Helpers;

namespace Farallon
{
    public class Equity
    {
        public string Ticker { get; set; }
        internal Trades Trades { get; set; } = new Trades();
        public decimal Cost => Trades.Trade.Sum(t => t.Cost);
        public int Quantity => Trades.Trade.Sum(t => t.Quantity);
        public AlphaVantageQuote AlphaVantageQuote { get; set; }
        public DateTime AsOfDate => AlphaVantageQuote.AlphaVantageGlobalQuote.LatestTradingDay.DateTime;
        public decimal CurrentPrice => ConversionHelper.ConvertToDecimal(AlphaVantageQuote.AlphaVantageGlobalQuote.Price);
        public decimal MarketValue => Quantity * CurrentPrice;
        public decimal PreviousClose => ConversionHelper.ConvertToDecimal(AlphaVantageQuote.AlphaVantageGlobalQuote.PreviousClose);
        public decimal InceptionPAndL => MarketValue - Cost;
        public decimal DailyPAndL => (CurrentPrice - PreviousClose) * Quantity;
    }
}
