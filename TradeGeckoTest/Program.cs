using System;
using TradeGeckoApi;

namespace TradeGeckoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new GeckoClient("", "", "");
            var products = client.Products.List();
            Console.ReadLine();
        }
    }
}
