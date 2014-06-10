using System;
using System.Collections.Generic;
using TradeGeckoApi;
using TradeGeckoApi.Model;

namespace TradeGeckoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new GeckoClient("", "", "");
            var order = client.Products.List();


            var ship = new Fulfillment();
            ship.BillingAddressId = 845576;
            ship.CreatedAt = DateTime.Now;
            ship.DeliveryType = "MF";
            ship.Notes = "From Connect";
            ship.OrderId = 260780;
            ship.PackedAt = DateTime.Now;
            ship.ShippedAt = DateTime.Now;
            ship.ReceivedAt = DateTime.Now;
            ship.ShippingAddressId = 845576;
            ship.Status = "packed";
            ship.TrackingNumber = "Track 123";
            ship.Items = new List<FulfillmentItem>();

            var item = new FulfillmentItem();
            item.Quantity = 2;
            item.BasePrice = 4.69m;
            item.OrderLineItemId = 1124257;
            ship.Items.Add(item);

            var item2 = new FulfillmentItem();
            item2.Quantity = 2;
            item2.BasePrice = 4.69m;
            item2.OrderLineItemId = 1124256;
            ship.Items.Add(item2);

            var respon = client.Fulfillments.Create(ship);
            Console.ReadLine();
        }
    }
}
