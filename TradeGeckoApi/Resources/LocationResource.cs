using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class LocationResource : Resource<Location>
    {
        public LocationResource(IRequestService requestService) : base(requestService) { }

        public LocationResource() { }

        protected override string ResourceUri { get { return "/locations"; } }
        protected override string ResourceItemUri { get { return "/locations/{id}"; } }

        protected override object ResolveIdFromModel(Location model)
        {
            return model.Id;
        }
    }
}
