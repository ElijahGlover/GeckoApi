using TradeGeckoApi.Resources;
using TradeGeckoApi.Service;

namespace TradeGeckoApi
{
    public class GeckoClient
    {
        private readonly IAuthenticationService _authentication;
        private readonly IRequestService _requestService;
        private readonly AddressResource _addresses;
        private readonly CompanyResource _companies;
        private readonly ContactResource _contacts;
        private readonly CurrencyResource _currencies;
        private readonly FulfillmentResource _fulfillments;
        private readonly FulfillmentItemResource _fulfillmentItems;
        private readonly LocationResource _locations;
        private readonly OrderResource _orders;
        private readonly OrderItemResource _orderItems;
        private readonly PaymentTermResource _paymentTerms;
        private readonly PriceListResource _priceLists;
        private readonly ProductResource _products;
        private readonly VariantResource _varients;
        private readonly InvoiceResource _invoices;
        private readonly InvoiceItemResource _invoiceItems;

        public GeckoClient(string applicationId, string secret, string callbackUrl, string url = null)
        {
            url = url ?? "https://api.tradegecko.com/";
            _authentication = new AuthenticationService(applicationId, secret, callbackUrl, url);
            _requestService = new RequestService(_authentication);
            _varients = new VariantResource(_requestService);
            _addresses = new AddressResource(_requestService);
            _companies = new CompanyResource(_requestService);
            _products = new ProductResource(_requestService);
            _priceLists = new PriceListResource(_requestService);
            _orders = new OrderResource(_requestService);
            _fulfillments = new FulfillmentResource(_requestService);
            _fulfillmentItems = new FulfillmentItemResource(_requestService);
            _orderItems = new OrderItemResource(_requestService);
            _contacts = new ContactResource(_requestService);
            _currencies = new CurrencyResource(_requestService);
            _locations = new LocationResource(_requestService);
            _paymentTerms = new PaymentTermResource(_requestService);
            _invoices = new InvoiceResource(_requestService);
            _invoiceItems = new InvoiceItemResource(_requestService);
        }

        public GeckoClient()
        {
        }

        public virtual IAuthenticationService Authentication
        {
            get { return _authentication; }
        }

        public virtual AddressResource Addresses
        {
            get { return _addresses; }
        }

        public virtual CompanyResource Companies
        {
            get { return _companies; }
        }

        public virtual ContactResource Contacts
        {
            get { return _contacts; }
        }

        public virtual CurrencyResource Currencies
        {
            get { return _currencies; }
        }

        public virtual FulfillmentResource Fulfillments
        {
            get { return _fulfillments; }
        }

        public virtual FulfillmentItemResource FulfillmentItems
        {
            get { return _fulfillmentItems; }
        }

        public virtual LocationResource Locations
        {
            get { return _locations; }
        }

        public virtual OrderResource Orders
        {
            get { return _orders; }
        }

        public virtual OrderItemResource OrderItems
        {
            get { return _orderItems; }
        }

        public virtual PaymentTermResource PaymentTerms
        {
            get { return _paymentTerms; }
        }

        public virtual PriceListResource PriceLists
        {
            get { return _priceLists; }
        }

        public virtual ProductResource Products
        {
            get { return _products; }
        }

        public virtual VariantResource Varients
        {
            get { return _varients; }
        }

        public InvoiceResource Invoices
        {
            get { return _invoices; }
        }

        public InvoiceItemResource InvoiceItems
        {
            get { return _invoiceItems; }
        }
    }
}
