using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Farallon.AlphaVantage;
using Farallon.Constants;
using Farallon.Helpers;
using Farallon.Interfaces;

namespace Farallon
{
    public class ProfitAndLoss : ColumnsCollection
    {
        private Trades _trades;
        private readonly Equities _equities = new Equities();

        internal Trades Trades
        {
            get => _trades;
            set
            {
                _trades = value;

                BuildEquities();
            }
        }

        private void BuildEquities()
        {
            _equities.Clear();

            var uniqueTickers = Trades.Trade.GroupBy(t => t.Ticker)
                .Select(grp => grp.First().Ticker)
                .ToList();

            foreach (var ticker in uniqueTickers)
            {
                var equity = new Equity
                {
                    Ticker = ticker,
                    AlphaVantageQuote = AlphaVantageQuote.FetchGlobalQuote(ticker)
                };

                foreach (var trade in Trades.Trade.Where(trade => trade.Ticker == ticker))
                {
                    equity.Trades.Trade.Add(trade);
                }

                _equities.Add(equity);
            }
        }

        public IList<IColumn> Columns()
        {
            return _columns ??= new List<IColumn>
            {
                new Column(ProfitAndLossColumnNames.ColumnNameTicker, HorizontalAlignment.Left, FormattingConstants.DefaultFormat),
                new Column(ProfitAndLossColumnNames.ColumnNameAsOfDate, HorizontalAlignment.Center, FormattingConstants.DateFormat),
                new Column(ProfitAndLossColumnNames.ColumnNameCost, HorizontalAlignment.Right, FormattingConstants.CurrencyFormat),
                new Column(ProfitAndLossColumnNames.ColumnNameQuantity, HorizontalAlignment.Right, FormattingConstants.IntegerFormat),
                new Column(ProfitAndLossColumnNames.ColumnNamePrice, HorizontalAlignment.Right, FormattingConstants.CurrencyFormat),
                new Column(ProfitAndLossColumnNames.ColumnNameMarketValue, HorizontalAlignment.Right, FormattingConstants.CurrencyFormat, 130),
                new Column(ProfitAndLossColumnNames.ColumnNamePreviousClose, HorizontalAlignment.Right, FormattingConstants.CurrencyFormat, 150),
                new Column(ProfitAndLossColumnNames.ColumnNameDailyPAndL, HorizontalAlignment.Right, FormattingConstants.CurrencyFormat),
                new Column(ProfitAndLossColumnNames.ColumnNameInceptionPAndL, HorizontalAlignment.Right, FormattingConstants.CurrencyFormat, 150)
            };
        }

        public IList<IRow> Rows()
        {
            var rows = new List<IRow>();

            foreach (var equity in _equities.Items)
            {
                var row = new Row();

                row.Values.Add(equity.Ticker);
                row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameAsOfDate), equity.AsOfDate)); // As of Date
                row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameCost), equity.Cost));
                row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameQuantity), equity.Quantity));
                row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNamePrice), equity.CurrentPrice)); // current price
                row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameMarketValue), equity.MarketValue)); // market value
                row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNamePreviousClose), equity.PreviousClose)); // previous close
                row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameDailyPAndL), equity.DailyPAndL)); // daily P&l
                row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameInceptionPAndL), equity.InceptionPAndL)); // inception P&l

                rows.Add(row);
            }

            rows.Add(TotalsRow());

            return rows;
        }

        private IRow TotalsRow()
        {
            var row = new Row();

            row.Values.Add("Total");
            row.Values.Add(string.Empty); 
            row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameCost), _equities.TotalCost));
            row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameQuantity), _equities.TotalQuantity));
            row.Values.Add(string.Empty); // current price
            row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameMarketValue), _equities.TotalMarketValue)); // market value
            row.Values.Add(string.Empty); // previous close
            row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameDailyPAndL), _equities.TotalDailyPAndL)); // daily P&l
            row.Values.Add(string.Format(Columns().ValueStringFormat(ProfitAndLossColumnNames.ColumnNameInceptionPAndL), _equities.TotalInceptionPAndL)); // inception P&l

            return row;
        }
    }
}