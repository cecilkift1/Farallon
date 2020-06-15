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
        public DateTime AsOfDate => AlphaVantageQuoteValid ? AlphaVantageQuote.AlphaVantageGlobalQuote.LatestTradingDay.DateTime : DateTime.Now;
        public decimal CurrentPrice => AlphaVantageQuoteValid ? ConversionHelper.ConvertToDecimal(AlphaVantageQuote.AlphaVantageGlobalQuote.Price) : 0;
        public decimal MarketValue => Quantity * CurrentPrice;
        public decimal PreviousClose => AlphaVantageQuoteValid ? ConversionHelper.ConvertToDecimal(AlphaVantageQuote.AlphaVantageGlobalQuote.PreviousClose) : 0;
        public decimal InceptionPAndL => MarketValue - Cost;
        public decimal DailyPAndL => (CurrentPrice - PreviousClose) * Quantity;

        private bool AlphaVantageQuoteValid => AlphaVantageQuote?.AlphaVantageGlobalQuote != null;
    }
}
