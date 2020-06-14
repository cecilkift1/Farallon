using System.Windows.Forms;
using Farallon.Interfaces;

namespace Farallon
{
    public class Column : IColumn
    {
        public string Text { get; }
        public HorizontalAlignment TextAlign { get; }
        public string ValueStringFormat { get; set; }
        public int MinimumWidth { get; set; }

        public Column(string text, 
            HorizontalAlignment horizontalAlignment,
            string valueStringFormat,
            int minimumWidth = 0)
        {
            Text = text;
            TextAlign = horizontalAlignment;
            ValueStringFormat = valueStringFormat;
            MinimumWidth = minimumWidth;
        }
    }
}
