Trade Gecko Api Bindings
========

**My time is limited to focus on this project, Quickbooks now owns TradeGecko please let them know you found this valuable and they can adopt this as an SDK under license MIT**

API bindings to create, read, update &amp; delete [TradeGecko](http://tradegecko.com/) resources. 

AuthenticationService currently depends on EntityFramework to store OAuth auth tokens. Entity Framework will automatically script and create a single table called 'OAuthAuthentication'
```xml
<configuration>
    <connectionStrings>
        <add name="OAuthAuthentication" connectionString="Server=.;Database=Dev;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
    </connectionStrings>
</configuration>
```


Create Connection With TradeGecko Account
```cs
var client = new GeckoClient("{Provide-Application-Id}", "{Provide-Application-Secret}", "{Your-Callback-Url}");

//1. Send user to external TradeGecko URL to generate authorize token
var uri = client.Authentication.GenerateAuthorizeUrl();
Response.Redirect(uri.ToString());

//2. TradeGecko sends the authorize code back in the querystring of the return url (This only needs to be set once)
client.Authentication.SetAuthorizeCode("{Returned-Authorize-Code}");

//3. A token is requested and stored in a backing database - using EntityFramework
```

List First 10 Products
```cs
foreach (var product in client.Products.List(Filters.Limit(10)))
{
    Console.WriteLine(product.Name);
}
```

Create New Order
```cs
var order = new Order
{
    BillingAddressId = 10001,
    ShippingAddressId = 10001,
    CompanyId = 7000,
    CurrencyId = 500,
    OrderItems = new[]
    {
        new OrderItem
        {
            Quantity = 10,
            Price = 10m,
            Freeform = true,
            Label = "Freeform"
        },
        new OrderItem
        {
            Quantity = 10,
            Price = 10m,
            VariantId = 4000
        }
    }
};

client.Orders.Save(order);
Console.WriteLine(order.Id.ToString())
```

[![Build status]
(https://ci.appveyor.com/api/projects/status/st9tmngm4b0hs79h)]
(https://ci.appveyor.com/project/ElijahGlover/geckoapi)

```PowerShell
Add-Package TradeGeckoApi
```
https://www.nuget.org/packages/TradeGeckoApi/

Further documentation is located at http://developer.tradegecko.com/
