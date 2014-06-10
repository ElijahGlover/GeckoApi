Trade Gecko Api Bindings
========

API bindings to create, read, update &amp; delete [TradeGecko](http://tradegecko.com/) resources. 

```cs
var client = new GeckoClient("[ApplicationId]", "[Secret]", "[CallbackUrl]");
//Send Client To Gecko OAuth Authorize Url
var uri = client.Authentication.GenerateAuthorizeUrl();
//Persist Authorization Code
client.Authentication.SetAuthorizeCode("[ReturnedAuthorizeCode]");
foreach (var product in client.Products.List(Filters.Limit(10)))
{
    Console.WriteLine(product.Name);
}
```

[![Build status]
(https://ci.appveyor.com/api/projects/status/st9tmngm4b0hs79h)]
(https://ci.appveyor.com/project/ElijahGlover/geckoapi)
