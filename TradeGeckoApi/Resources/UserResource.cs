using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class UserResource : Resource<User>
    {
        public UserResource(IRequestService requestService) : base(requestService) { }

        public UserResource() { }

        protected override string ResourceUri { get { return "/users"; } }
        protected override string ResourceItemUri { get { return "/users/{id}"; } }

        protected override object ResolveIdFromModel(User model)
        {
            return model.Id;
        }
    }
}
