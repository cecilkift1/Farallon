using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;
using Farallon.Helpers;
using Farallon.Interfaces;

namespace Farallon
{
    [XmlRoot(ElementName = "trades")]
    public class Trades : Table
    {
        [XmlElement(ElementName = "trade")]
        public List<Trade> Trade { get; set; }

        public override PropertyInfo[] Properties()
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
                    var columnAttribute = propertyInfo.GetAttribute<ColumnAttribute>(false);

                    row.Values.Add(string.Format(columnAttribute?.ValueStringFormat ?? "{0}",
                        propertyInfo.GetValue(trade)));
                }

                rows.Add(row);
            }

            return rows;
        }
    }
}
