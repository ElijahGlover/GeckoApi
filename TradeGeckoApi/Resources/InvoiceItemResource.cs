using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class InvoiceItemResource : Resource<InvoiceItem>
    {
        public InvoiceItemResource(IRequestService client) : base(client) { }

        public InvoiceItemResource() { }

        protected override string ResourceUri { get { return "/invoice_line_items"; } }
        protected override string ResourceItemUri { get { return "/invoice_line_items/{id}"; } }
        protected override object ResolveIdFromModel(InvoiceItem model)
        {
            return model.Id;
        }

        public virtual IPaginationList<InvoiceItem> ByInvoiceId(int invoiceId)
        {
            return List(Filters.ByInvoice(invoiceId));
        }
    }
}
