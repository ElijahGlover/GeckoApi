using System;
using TradeGeckoApi.Resources;
using TradeGeckoApi.Service;

namespace TradeGeckoApi
{
    public class GeckoClient
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IRequestService _requestService;
        private Lazy<AddressResource> _addresses;
        private Lazy<CompanyResource> _companies;
        private Lazy<ContactResource> _contacts;
        private Lazy<CurrencyResource> _currencies;
        private Lazy<FulfillmentResource> _fulfillments;
        private Lazy<FulfillmentItemResource> _fulfillmentItems;
        private Lazy<LocationResource> _locations;
        private Lazy<OrderResource> _orders;
        private Lazy<OrderItemResource> _orderItems;
        private Lazy<PaymentTermResource> _paymentTerms;
        private Lazy<PriceListResource> _priceLists;
        private Lazy<ProductResource> _products;
        private Lazy<VariantResource> _varients;
        private Lazy<InvoiceResource> _invoices;
        private Lazy<InvoiceItemResource> _invoiceItems;
        private Lazy<UserResource> _users; 

        public GeckoClient(string applicationId, string secret, string callbackUrl, string url = null)
        {
            url = url ?? "https://api.tradegecko.com/";
            _authenticationService = new AuthenticationService(applicationId, secret, callbackUrl, url);
            _requestService = new RequestService(_authenticationService, url);
            InitResources();
        }

        public GeckoClient(IAuthenticationService authenticationServiceService, IRequestService requestService)
        {
            _authenticationService = authenticationServiceService;
            _requestService = requestService;
            InitResources();
        }

        private void InitResources()
        {
            _varients = new Lazy<VariantResource>(() => new VariantResource(_requestService));
            _addresses = new Lazy<AddressResource>(() => new AddressResource(_requestService));
            _companies = new Lazy<CompanyResource>(() => new CompanyResource(_requestService));
            _products = new Lazy<ProductResource>(() => new ProductResource(_requestService));
            _priceLists = new Lazy<PriceListResource>(() => new PriceListResource(_requestService));
            _orders = new Lazy<OrderResource>(() => new OrderResource(_requestService));
            _fulfillments = new Lazy<FulfillmentResource>(() => new FulfillmentResource(_requestService));
            _fulfillmentItems = new Lazy<FulfillmentItemResource>(() => new FulfillmentItemResource(_requestService));
            _orderItems = new Lazy<OrderItemResource>(() => new OrderItemResource(_requestService));
            _contacts = new Lazy<ContactResource>(() => new ContactResource(_requestService));
            _currencies = new Lazy<CurrencyResource>(() => new CurrencyResource(_requestService));
            _locations = new Lazy<LocationResource>(() => new LocationResource(_requestService));
            _paymentTerms = new Lazy<PaymentTermResource>(() => new PaymentTermResource(_requestService));
            _invoices = new Lazy<InvoiceResource>(() => new InvoiceResource(_requestService));
            _invoiceItems = new Lazy<InvoiceItemResource>(() => new InvoiceItemResource(_requestService));
            _users = new Lazy<UserResource>(() => new UserResource(_requestService));
        }

        public GeckoClient()
        {
            //Used For Mocking Resouces
        }

        public virtual IAuthenticationService Authentication
        {
            get { return _authenticationService; }
        }

        public virtual AddressResource Addresses
        {
            get { return _addresses.Value; }
        }

        public virtual CompanyResource Companies
        {
            get { return _companies.Value; }
        }

        public virtual ContactResource Contacts
        {
            get { return _contacts.Value; }
        }

        public virtual CurrencyResource Currencies
        {
            get { return _currencies.Value; }
        }

        public virtual FulfillmentResource Fulfillments
        {
            get { return _fulfillments.Value; }
        }

        public virtual FulfillmentItemResource FulfillmentItems
        {
            get { return _fulfillmentItems.Value; }
        }

        public virtual LocationResource Locations
        {
            get { return _locations.Value; }
        }

        public virtual OrderResource Orders
        {
            get { return _orders.Value; }
        }

        public virtual OrderItemResource OrderItems
        {
            get { return _orderItems.Value; }
        }

        public virtual PaymentTermResource PaymentTerms
        {
            get { return _paymentTerms.Value; }
        }

        public virtual PriceListResource PriceLists
        {
            get { return _priceLists.Value; }
        }

        public virtual ProductResource Products
        {
            get { return _products.Value; }
        }

        public virtual VariantResource Varients
        {
            get { return _varients.Value; }
        }

        public InvoiceResource Invoices
        {
            get { return _invoices.Value; }
        }

        public InvoiceItemResource InvoiceItems
        {
            get { return _invoiceItems.Value; }
        }

        public UserResource Users
        {
            get { return _users.Value; }
        }
    }
}
