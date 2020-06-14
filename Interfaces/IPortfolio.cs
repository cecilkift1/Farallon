using System.Collections.Generic;
using Farallon.Enums;

namespace Farallon.Interfaces
{
    public interface IPortfolio
    {
        IList<IColumn> Columns(PortfolioViewType portfolioViewType);
        IList<IRow> Rows(PortfolioViewType portfolioViewType);
    }
}
