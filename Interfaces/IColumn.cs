using System.Windows.Forms;

namespace Farallon.Interfaces
{
    public interface IColumn
    {
        string Text { get; }
        HorizontalAlignment TextAlign { get; }
    }
}
