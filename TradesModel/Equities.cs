using System.Collections.Generic;
using System.Linq;

namespace Farallon
{
    public class Equities
    {
        public IList<Equity> Items = new List<Equity>();
        public decimal TotalCost => Items.Sum(i => i.Cost);
        public int TotalQuantity => Items.Sum(i => i.Quantity);
        public decimal TotalMarketValue => Items.Sum(i => i.MarketValue);
        public decimal TotalDailyPAndL => Items.Sum(i => i.DailyPAndL);
        public decimal TotalInceptionPAndL => Items.Sum(i => i.InceptionPAndL);

        public void Clear()
        {
            Items.Clear();
        }

        public void Add(Equity equity)
        {
            Items.Add(equity);
        }
    }
}