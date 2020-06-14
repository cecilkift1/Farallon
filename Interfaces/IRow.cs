using System.Collections.Generic;

namespace Farallon.Interfaces
{
    public interface IRow
    {
        IList<string> Values { get; }
    }
}