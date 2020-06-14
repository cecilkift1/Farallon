using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using Farallon.Constants;
using Farallon.Enums;
using Farallon.Helpers;

namespace Farallon
{
    [XmlRoot(ElementName = "trade")]
    public class Trade
    {
        [XmlElement("ticker"), DisplayName("Ticker")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Left, 
            ValueStringFormat = FormattingConstants.DefaultFormat)]
        public string Ticker { get; set; }

        [XmlElement("tradeDate"), DisplayName("Trade Date")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Center, 
            ValueStringFormat = FormattingConstants.DateFormat)] 
        public DateTime TradeDate { get; set; }

        [XmlElement("quantity"), DisplayName("Quantity")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Right, 
            ValueStringFormat = FormattingConstants.IntegerFormat)]
        public int Quantity { get; set; }

        [XmlElement("action", typeof(TradeAction)), DisplayName("Action")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Center, 
            ValueStringFormat = FormattingConstants.DefaultFormat)]
        public TradeAction Action { get; set; }

        [XmlElement("price"), DisplayName("Price")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Right, 
            ValueStringFormat = FormattingConstants.CurrencyFormat)]
        public decimal Price { get; set; }

        [XmlElement("cost"), DisplayName("Cost")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Right, 
            ValueStringFormat = FormattingConstants.CurrencyFormat)]
        public decimal Cost { get; set; }
    }
}