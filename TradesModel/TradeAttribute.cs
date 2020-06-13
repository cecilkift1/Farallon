using System;
using System.Windows.Forms;

namespace Farallon
{
    public class TradeAttribute : Attribute
    {
        public HorizontalAlignment HorizontalAlignment { get; set; }
        public string ValueStringFormat { get; set; }
    }
}