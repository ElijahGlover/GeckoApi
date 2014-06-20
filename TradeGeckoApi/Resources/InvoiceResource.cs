using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class InvoiceResource : Resource<Invoice>
    {
        public InvoiceResource(IRequestService requestService) : base(requestService) { }

        public InvoiceResource() { }

        protected override string ResourceUri { get { return "/invoices"; } }
        protected override string ResourceItemUri { get { return "/invoices/{id}"; } }
        protected override object ResolveIdFromModel(Invoice model)
        {
            return model.Id;
        }
    }
}
