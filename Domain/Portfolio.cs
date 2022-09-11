using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Portfolio : IPortfolio
    {
        public DateTime ReferenceDate { get; set;  }
        public int Trades { get; set;  }
        public List<ITrade> TradeList { get; set; }

        public Portfolio()
        {
            TradeList = new List<ITrade>();
        }
    }
}
