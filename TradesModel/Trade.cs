using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Farallon.Constants;
using Farallon.Enums;

namespace Farallon
{
    [XmlRoot(ElementName = "trade")]
    public class Trade
    {
        [XmlElement("ticker"), DisplayName(TradeColumnNames.ColumnNameTicker)]
        public string Ticker { get; set; }

        [XmlElement("tradeDate"), DisplayName(TradeColumnNames.ColumnNameTradeDate)] 
        public DateTime TradeDate { get; set; }

        [XmlElement("quantity"), DisplayName(TradeColumnNames.ColumnNameQuantity)]
        public int Quantity { get; set; }

        [XmlElement("action", typeof(TradeAction)), DisplayName(TradeColumnNames.ColumnNameAction)]
        public TradeAction Action { get; set; }

        [XmlElement("price"), DisplayName(TradeColumnNames.ColumnNamePrice)]
        public decimal Price { get; set; }

        [XmlElement("cost"), DisplayName(TradeColumnNames.ColumnNameCost)]
        public decimal Cost { get; set; }
    }
}