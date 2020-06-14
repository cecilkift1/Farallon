using System.Net;

namespace Farallon.AlphaVantage
{
    public static class AlphaVantageBaseConnection
    {
        const string ApiKey = "2DLJXQV5J55J3NG9";

        public static string GetDownloadString(string functionName, string ticker)
        {
            using var client = new WebClient();
            return client.DownloadString($"https://www.alphavantage.co/query?function={functionName}&symbol={ticker}&apikey={ApiKey}");
        }
    }
}
