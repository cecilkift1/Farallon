using System;
using System.Windows.Forms;
using Farallon.AlphaVantage;
using Farallon.Constants;
using Farallon.CustomControls;
using Farallon.Helpers;

namespace Farallon
{
    public partial class FarallonMainForm : BaseForm
    {
        public FarallonMainForm()
        {
            InitializeComponent();
        }

        private void FarallonMainForm_Load(object sender, EventArgs e)
        {
            listViewPortfolio.Portfolio = Portfolio;
            listViewProfitAndLoss.Portfolio = Portfolio;
        }

        private void buttonQuote_Click(object sender, EventArgs e)
        {
            PerformQuoteSearch(textBoxQuote.Text);
        }

        private void PerformQuoteSearch(string ticker)
        { 
            var currentStockQuote = AlphaVantageQuote.FetchGlobalQuote(ticker);
            if (currentStockQuote?.AlphaVantageGlobalQuote == null)
            {
                labelQuoteTicker.Text = $"Ticker: Invalid ticker: {ticker}";
                labelQuoteData.Text = string.Empty;
            }
            else
            {
                labelQuoteTicker.Text = $"Ticker: {currentStockQuote.AlphaVantageGlobalQuote.Symbol}"; 
                labelQuoteData.Text = $"Quote: {string.Format(FormattingConstants.CurrencyFormat, ConversionHelper.ConvertToDecimal(currentStockQuote.AlphaVantageGlobalQuote.Price))}";
            }
        }

        private void textBoxQuote_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control) sender, true, true, true, true);
                PerformQuoteSearch(textBoxQuote.Text);
            }
        }
    }
}
