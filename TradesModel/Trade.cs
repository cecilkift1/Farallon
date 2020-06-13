using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Farallon
{
    [XmlRoot(ElementName = "trade")]
    public class Trade
    {
        [XmlElement("ticker"), DisplayName("Symbol")]
        [Trade(HorizontalAlignment = HorizontalAlignment.Left, ValueStringFormat = "{0}")]
        public string Ticker { get; set; }

        [XmlElement("tradeDate"), DisplayName("Trade Date")]
        [Trade(HorizontalAlignment = HorizontalAlignment.Center, ValueStringFormat = "{0:MM-dd-yyyy}")] 
        public DateTime TradeDate { get; set; }

        [XmlElement("quantity"), DisplayName("Quantity")]
        [Trade(HorizontalAlignment = HorizontalAlignment.Right, ValueStringFormat = "{0:N0}")]
        public int Quantity { get; set; }

        [XmlElement("action", typeof(TradeAction)), DisplayName("Action")]
        [Trade(HorizontalAlignment = HorizontalAlignment.Center, ValueStringFormat = "{0}")]
        public TradeAction Action { get; set; }

        [XmlElement("price"), DisplayName("Price")]
        [Trade(HorizontalAlignment = HorizontalAlignment.Right, ValueStringFormat = "{0:C}")]
        public decimal Price { get; set; }

        [XmlElement("cost"), DisplayName("Cost")]
        [Trade(HorizontalAlignment = HorizontalAlignment.Right, ValueStringFormat = "{0:C}")]
        public decimal Cost { get; set; }
    }
}