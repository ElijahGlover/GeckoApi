using System.Linq;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using TradeGeckoApi.Exceptions;
using TradeGeckoApi.Model;

namespace TradeGeckoApi.Service
{
    public class RequestService : IRequestService
    {
        private readonly IAuthenticationService _authentication;
        public const string PaginationHeader = "X-Pagination";

        public RequestService(IAuthenticationService authentication)
        {
            _authentication = authentication;
        }

        public void ExecuteRequest(RestRequest request)
        {
            var client = _authentication.CreateClient();
            var response = client.Execute(request);
            InspectResponse(response);
        }

        public T ExecuteRequest<T>(RestRequest request)
        {
            var client = _authentication.CreateClient();
            var response = client.Execute<ItemResponse<T>>(request);
            InspectResponse(response);
            return response.Data.Data;
        }

        public IPaginationList<T> ExecuteListRequest<T>(RestRequest request)
        {
            var client = _authentication.CreateClient();
            var response = client.Execute<ListResponse<T>>(request);
            InspectResponse(response);

            var paginationHeader = response.Headers.FirstOrDefault(p => p.Name == PaginationHeader);

            var pagination = paginationHeader != null
                ? JsonConvert.DeserializeObject<PaginationModel>(paginationHeader.Value.ToString())
                : null;

            return new PaginationList<T>(response.Data.Data, pagination);
        }

        protected void InspectResponse(IRestResponse response)
        {
            if (response.ErrorException != null)
                throw new RequestException("There was a problem processing the request, see inner exception for details", response.ErrorException);

            if (response.StatusCode == HttpStatusCode.NotFound)
                throw new NotFoundException(string.Format("Resource With Uri '{0}' Couldn't Be Found", response.ResponseUri));

            if (response.StatusCode == HttpStatusCode.BadRequest)
                throw new InvalidRequestException(string.Format("BadRequest {0}", response.Content));

            if (response.StatusCode == HttpStatusCode.Forbidden)
                throw new AuthenticationException(string.Format("Request ApiId/Signature Invalid, {0}", response.Content));

            if (response.StatusCode == HttpStatusCode.InternalServerError)
                throw new RequestException(string.Format("There was a problem processing the request {0}", response.Content));
        }
    }
}
