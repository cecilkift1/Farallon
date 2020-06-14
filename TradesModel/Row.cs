using System.Collections.Generic;
using Farallon.Interfaces;

namespace Farallon
{
    public class Row :IRow
    {
        public IList<string> Values { get; set; } = new List<string>();
    }
}
