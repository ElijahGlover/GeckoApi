using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class PaymentTermResource : Resource<PaymentTerm>
    {
        public PaymentTermResource(IRequestService authentication) : base(authentication) { }

        public PaymentTermResource() { }

        protected override string ResourceUri { get { return "/payment_terms"; } }
        protected override string ResourceItemUri { get { return "/payment_terms/{id}"; } }

        protected override object ResolveIdFromModel(PaymentTerm model)
        {
            return model.Id;
        }
    }
}
