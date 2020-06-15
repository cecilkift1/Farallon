using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;
using Farallon.Constants;
using Farallon.Helpers;
using Farallon.Interfaces;

namespace Farallon
{
    [XmlRoot(ElementName = "trades")]
    public class Trades : ColumnsCollection
    {
        [XmlElement(ElementName = "trade")]
        public List<Trade> Trade { get; set; } = new List<Trade>();

        public IList<IColumn> Columns()
        {
            return _columns ??= new List<IColumn>
            {
                new Column(TradeColumnNames.ColumnNameTicker, HorizontalAlignment.Left, FormattingConstants.DefaultFormat),
                new Column(TradeColumnNames.ColumnNameTradeDate, HorizontalAlignment.Center, FormattingConstants.DateFormat),
                new Column(TradeColumnNames.ColumnNameQuantity, HorizontalAlignment.Right, FormattingConstants.IntegerFormat),
                new Column(TradeColumnNames.ColumnNameAction, HorizontalAlignment.Center, FormattingConstants.DefaultFormat),
                new Column(TradeColumnNames.ColumnNamePrice, HorizontalAlignment.Right, FormattingConstants.CurrencyFormat),
                new Column(TradeColumnNames.ColumnNameCost, HorizontalAlignment.Right, FormattingConstants.CurrencyFormat)
            };
        }

        private PropertyInfo[] Properties()
        {
            return typeof(Trade).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        public IList<IRow> Rows()
        {
            var rows = new List<IRow>();
            var properties = Properties();

            foreach (var trade in Trade)
            {
                var row = new Row();

                foreach (var propertyInfo in properties)
                {
                    var displayNameAttribute = propertyInfo.GetAttribute<DisplayNameAttribute>(false);
                    var columnName = displayNameAttribute == null ? propertyInfo.Name : displayNameAttribute.DisplayName;
                    row.Values.Add(string.Format(Columns().ValueStringFormat(columnName), propertyInfo.GetValue(trade)));
                }

                rows.Add(row);
            }

            return rows;
        }
    }
}
