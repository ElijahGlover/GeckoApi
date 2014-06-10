using System;
using System.ComponentModel.DataAnnotations;

namespace TradeGeckoApi.Context
{
    public class OAuthAuthentication
    {
        [Key]
        public string AuthorizeCode { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiry { get; set; }
    }
}
