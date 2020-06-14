using System;
using System.Collections.Generic;
using Farallon.Enums;
using Farallon.Interfaces;

namespace Farallon
{
    public class Portfolio : IPortfolio
    {
        private ProfitAndLoss ProfitAndLoss { get; } = new ProfitAndLoss();
        private Trades Trades { get; set; } = new Trades();

        public Portfolio(string xmlFilename)
        {
            LoadFromXmlFile(xmlFilename);
        }

        public IList<IColumn> Columns(PortfolioViewType portfolioViewType)
        {
            return portfolioViewType == PortfolioViewType.Trades ?
                Trades.Columns() : 
                ProfitAndLoss.Columns();
        }

        public IList<IRow> Rows(PortfolioViewType portfolioViewType)
        {
            return portfolioViewType == PortfolioViewType.Trades ?
                Trades.Rows() :
                ProfitAndLoss.Rows();
        }


        private void LoadFromXmlFile(string xmlFilename)
        {
            try
            {
                var reader = new System.Xml.Serialization.XmlSerializer(typeof(Trades));
                using var file = new System.IO.StreamReader(xmlFilename);
                Trades = (Trades)reader.Deserialize(file);
                ProfitAndLoss.Trades = Trades;
                file.Close();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to load portfolio data from file, Error: {e.Message}");
            }
        }
    }
}
