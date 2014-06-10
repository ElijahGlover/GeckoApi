using System;
using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("users", "user")]
    public class User
    {
        public int? Id { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        public string Email { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        public string Status { get; set; }
        [JsonProperty("last_sign_in_at")]
        public DateTime? LastSignInAt { get; set; }
        public string Location { get; set; }
        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        public string[] Roles { get; set; }
    }
}
