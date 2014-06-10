using System.Data.Entity.Migrations;

namespace TradeGeckoApi.Context
{
    public class Configuration : DbMigrationsConfiguration<OAuthDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
