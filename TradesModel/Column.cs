using System.Windows.Forms;
using Farallon.Interfaces;

namespace Farallon
{
    public class Column : IColumn
    {
        public string Text { get; }
        public HorizontalAlignment TextAlign { get; }

        public Column(string text, HorizontalAlignment horizontalAlignment)
        {
            Text = text;
            TextAlign = horizontalAlignment;
        }
    }
}
