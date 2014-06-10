using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class VariantResource : Resource<Variant>
    {
        public VariantResource(IRequestService client) : base(client) { }

        public VariantResource() { }

        protected override string ResourceUri { get { return "/variants"; } }
        protected override string ResourceItemUri { get { return "/variants/{id}"; } }

        protected override object ResolveIdFromModel(Variant model)
        {
            return model.Id;
        }

        public virtual IPaginationList<Variant> ByProductId(int productId)
        {
            return List(Filters.ByProduct(productId));
        }
    }
}
