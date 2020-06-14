using System;
using System.Net;
using Farallon.AlphaVantage;
using Farallon.CustomControls;
using Newtonsoft.Json;

namespace Farallon
{
    public partial class FarallonMainForm : BaseForm
    {
        public FarallonMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var symbol = "MSFT";
            //  var apiKey = "2DLJXQV5J55J3NG9"; // retrieve your api key from

            using var client = new WebClient();

            client.Headers.Add("User-Agent", "C# console program");
            var url = $"https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol={symbol}&apikey=demo";
            var contentJson = client.DownloadString(url);

            var currentStockQuote = JsonConvert.DeserializeObject<AlphaVantageQuote>(contentJson);
            System.Diagnostics.Debug.WriteLine(currentStockQuote);
        }

        private void FarallonMainForm_Load(object sender, EventArgs e)
        {
            listViewPortfolio.Portfolio = Portfolio;
            listViewProfitAndLoss.Portfolio = Portfolio;
        }
    }
}
