using Domain;

namespace Service
{
    public class PortfolioServices
    {
        IPortfolio portfolio { get; }

        public PortfolioServices()
        {
            portfolio = new Portfolio();            
        }

        public void AddTrade(Double TradeAmount, CatTypes Category, DateTime pendingPayment)
        {
            
            portfolio.TradeList.Add(new Trade(TradeAmount, Category.ToString(), pendingPayment));                
        }

        public void ClassifyPortfloio()
        {
            foreach(Trade t in portfolio.TradeList)
            {
                //Check expired
                if (portfolio.ReferenceDate > t.NextPaymentDate && (portfolio.ReferenceDate - t.NextPaymentDate).Days > 30)
                {
                    Console.WriteLine("EXPIRED");
                    continue;
                }

                //Check high risk
                if (t.Value > 1000000 && (t.ClientSector).Equals("Private"))
                {
                    Console.WriteLine("HIGHRISK");
                    continue;
                }

                //Check medium risk
                if (t.Value > 1000000 && (t.ClientSector).Equals("Public"))
                {
                    Console.WriteLine("MEDIUMRISK");
                    continue;
                }
            }
        }

        public void AddReferenceDate(DateTime date)            
        {
            portfolio.ReferenceDate = date;
        }

        public enum CatTypes
        {
            Public,
            Private
        }
    }

}
