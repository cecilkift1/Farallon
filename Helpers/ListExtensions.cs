using System.Collections.Generic;
using System.Linq;
using Farallon.Constants;
using Farallon.Interfaces;

namespace Farallon.Helpers
{
    public static class ListExtensions
    {
        public static string ValueStringFormat(this IList<IColumn> list, string columnDisplayName)
        {
            var column = list?.FirstOrDefault(c => string.CompareOrdinal(c.Text, columnDisplayName) == 0);

            return column != null ? column.ValueStringFormat : FormattingConstants.DefaultFormat;
        }
    }
}