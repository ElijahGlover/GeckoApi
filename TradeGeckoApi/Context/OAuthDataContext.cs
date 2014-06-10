using System.Data.Entity;

namespace TradeGeckoApi.Context
{
    public class OAuthDataContext : DbContext
    {
        public OAuthDataContext() : base("OAuthAuthentication") {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OAuthDataContext, Configuration>());
        }

        public DbSet<OAuthAuthentication> OAuthAuthentication { get; set; }
    }
}
