using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using Farallon.CustomControls;
using Farallon.Helpers;

namespace Farallon
{
    public class Portfolio
    {
        public Trades Trades { get; private set; }

        public void Initialize(string fileName, CustomListView listView)
        {
            try
            {
                var reader = new System.Xml.Serialization.XmlSerializer(typeof(Trades));
                using var file = new System.IO.StreamReader(fileName);
                Trades = (Trades)reader.Deserialize(file);
                file.Close();

                Populate(listView);
            }
            catch (Exception e)
            {
                listView.Items.Clear();
                System.Diagnostics.Debug.WriteLine($"Failed to load portfolio data from file, Error: {e.Message}");
            }
        }

        private void Populate(CustomListView listView)
        {
            try
            {
                listView.BeginUpdate();

                CreateListViewColumns(listView);
                CreateListViewItems(listView);
            }
            finally
            {
                listView.EndUpdate();
            }
        }

        private void CreateListViewItems(CustomListView listView)
        {
            listView.Items.Clear();

            var properties = typeof(Trade).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var portfolioTrade in Trades.Trade)
            {
                ListViewItem tradeListViewItem = null;
                foreach (var propertyInfo in properties)
                {
                    var tradeAttribute = propertyInfo.GetAttribute<TradeAttribute>(false);

                    if (tradeListViewItem == null)
                    {
                        tradeListViewItem = new ListViewItem
                        {
                            Text = string.Format(tradeAttribute?.ValueStringFormat ?? "{0}",
                                propertyInfo.GetValue(portfolioTrade))
                        };

                        listView.Items.Add(tradeListViewItem);
                    }
                    else
                    {
                        tradeListViewItem.SubItems.Add(string.Format(tradeAttribute?.ValueStringFormat ?? "{0}",
                            propertyInfo.GetValue(portfolioTrade)));
                    }
                }
            }
        }

        private static void CreateListViewColumns(CustomListView listView)
        {
            listView.Columns.Clear();

            var properties = typeof(Trade).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var propertyInfo in properties)
            {
                var displayNameAttribute = propertyInfo.GetAttribute<DisplayNameAttribute>(false);
                var tradeAttribute = propertyInfo.GetAttribute<TradeAttribute>(false);

                var columnHeader = new ColumnHeader
                {
                    TextAlign = tradeAttribute?.HorizontalAlignment ?? HorizontalAlignment.Left,
                    Text = displayNameAttribute == null ? propertyInfo.Name : displayNameAttribute.DisplayName
                };

                listView.Columns.Add(columnHeader);
            }
        }
    }
}
