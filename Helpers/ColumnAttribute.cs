using System;
using System.Windows.Forms;

namespace Farallon.Helpers
{
    public class ColumnAttribute : Attribute
    {
        public HorizontalAlignment HorizontalAlignment { get; set; }
        public string ValueStringFormat { get; set; }
    }
}