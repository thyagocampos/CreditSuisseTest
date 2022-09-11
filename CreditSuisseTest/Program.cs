using Service;
using System;
using System.Globalization;
using static Service.PortfolioServices;

public class Example
{
    static PortfolioServices service;
    static int numberOfTrades;

    public static void Main()
    {
        string trade;                

        service = new PortfolioServices();

        Console.WriteLine("Input reference date");
        service.AddReferenceDate(DateTime.Parse(Console.ReadLine(), new CultureInfo("en-US")));

        Console.WriteLine("Input number of trades in portfolio");
        numberOfTrades = int.Parse(Console.ReadLine());

        //Adding trades to portifolio
        for (int i = 0; i < numberOfTrades; i++)
        {
            trade = Console.ReadLine();

            service.AddTrade(
                double.Parse(trade.Split(' ')[0]),
                (CatTypes)Enum.Parse(typeof(CatTypes), trade.Split(' ')[1]),
                DateTime.Parse(trade.Split(' ')[2], new CultureInfo("en-US")));
        }

        //Calculating risks of portfolio's trades
        service.ClassifyPortfloio();

    }
}