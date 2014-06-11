using RestSharp;
using System;
using System.Linq;

namespace TradeGeckoApi
{
    public static class Filters
    {
        public static Parameter[] ByIds(params int[] ids)
        {
            return ids.Select(p => new Parameter { Name = "ids[]", Value = p, Type = ParameterType.GetOrPost }).ToArray();
        }

        public static Parameter[] UpdatedAtMin(DateTime timestamp)
        {
            return new[] { new Parameter { Name = "updated_at_min", Value = timestamp.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK"), Type = ParameterType.GetOrPost } };
        }

        public static Parameter[] UpdatedAtMax(DateTime timestamp)
        {
            return new[] { new Parameter { Name = "updated_at_max", Value = timestamp.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK"), Type = ParameterType.GetOrPost } };
        }

        public static Parameter[] Order(string syntax)
        {
            return new[] { new Parameter { Name = "order", Value = syntax ?? "", Type = ParameterType.GetOrPost } };
        }

        public static Parameter[] Limit(int count)
        {
            return new[] { new Parameter { Name = "limit", Value = count, Type = ParameterType.GetOrPost } };
        }

        public static Parameter[] Page(int count)
        {
            return new[] { new Parameter { Name = "page", Value = count, Type = ParameterType.GetOrPost } };
        }

        public static Parameter[] ByCompany(int companyId)
        {
            return new[] { new Parameter { Name = "company_id", Value = companyId, Type = ParameterType.GetOrPost } };
        }

        public static Parameter[] ByOrder(int orderId)
        {
            return new[] { new Parameter { Name = "order_id", Value = orderId, Type = ParameterType.GetOrPost } };
        }

        public static Parameter[] ByProduct(int productId)
        {
            return new[] { new Parameter { Name = "product_id", Value = productId, Type = ParameterType.GetOrPost } };
        }

        public static Parameter[] ByOrderNumber(string orderNumber)
        {
            return new[] { new Parameter { Name = "order_number", Value = orderNumber, Type = ParameterType.GetOrPost } };
        }

        public static Parameter[] ByFulfillment(int fulfillmentId)
        {
            return new[] { new Parameter {Name = "fulfillment_id", Value = fulfillmentId, Type = ParameterType.GetOrPost } };
        }

        public static Parameter[] ByInvoice(int invoiceId)
        {
            return new[] { new Parameter { Name = "invoice_id", Value = invoiceId, Type = ParameterType.GetOrPost } };
        }
    }
}
