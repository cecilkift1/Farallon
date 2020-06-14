using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using Farallon.Helpers;
using Farallon.Interfaces;

namespace Farallon
{
    public abstract class Table
    {
        public abstract PropertyInfo[] Properties();

        public virtual IList<IColumn> Columns()
        {
            var columns = new List<IColumn>();
            var properties = Properties();

            foreach (var propertyInfo in properties)
            {
                var displayNameAttribute = propertyInfo.GetAttribute<DisplayNameAttribute>(false);
                var columnAttribute = propertyInfo.GetAttribute<ColumnAttribute>(false);
                var columnText = displayNameAttribute == null ? propertyInfo.Name : displayNameAttribute.DisplayName;
                var columnTextAlign = columnAttribute?.HorizontalAlignment ?? HorizontalAlignment.Left;

                columns.Add(new Column(columnText, columnTextAlign));
            }

            return columns;
        }
    }
}