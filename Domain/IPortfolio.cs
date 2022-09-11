using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IPortfolio
    {
        DateTime ReferenceDate { get; set; }
        int Trades { get; set; }
        List<ITrade> TradeList { get; set; }
    }

}