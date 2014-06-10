using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class ProductResource : Resource<Product>
    {
        public ProductResource(IRequestService client) : base(client) { }

        public ProductResource() { }

        protected override string ResourceUri { get { return "/products"; } }
        protected override string ResourceItemUri { get { return "/products/{id}"; } }

        protected override object ResolveIdFromModel(Product model)
        {
            return model.Id;
        }
    }
}
