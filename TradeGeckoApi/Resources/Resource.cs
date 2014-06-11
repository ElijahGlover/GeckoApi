using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RestSharp;
using TradeGeckoApi.Model;
using TradeGeckoApi.Serialization;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public abstract class Resource<T> where T : class
    {
        protected readonly IRequestService RequestService;

        protected Resource() { }

        protected Resource(IRequestService requestService)
        {
            RequestService = requestService;
        }

        protected abstract string ResourceUri { get; }
        protected abstract string ResourceItemUri { get; }
        protected abstract object ResolveIdFromModel(T model);

        protected RestRequest CreateRequest(string uri, Method method = Method.GET)
        {
            return new RestRequest(uri, method)
            {
                JsonSerializer = new JsonNetSerializer(),
                RequestFormat = DataFormat.Json
            };
        }

        protected IDictionary<string, T> WrapModel(T model)
        {
            var attr = typeof(T).GetCustomAttribute<RootPropertyNameAttribute>();
            return new Dictionary<string, T> {{attr.SingularName, model}};
        }

        public virtual T ById(int id)
        {
            var request = CreateRequest(ResourceItemUri);
            request.AddParameter("id", id, ParameterType.GetOrPost);
            return RequestService.ExecuteRequest<T>(request);
        }

        public virtual IPaginationList<T> List(params Parameter[] parameters)
        {
            var request = CreateRequest(ResourceUri);
            foreach (var parameter in parameters)
                request.AddParameter(parameter.Name, parameter.Value);
            return RequestService.ExecuteListRequest<T>(request);
        }

        public virtual IPaginationList<T> List(params Parameter[][] parameters)
        {
            var flatParameters = parameters
                .SelectMany(p => p)
                .ToArray();
            return List(flatParameters);
        }

        public virtual IPaginationList<T> List()
        {
            return List(new Parameter[] {});
        }

        public virtual void Delete(int id)
        {
            var request = CreateRequest(ResourceItemUri, Method.DELETE);
            request.AddParameter("id", id, ParameterType.UrlSegment);
            RequestService.ExecuteRequest(request);
        }

        public virtual T Create(T model)
        {
            if (model == null)
                throw new ArgumentNullException("model");

            var request = CreateRequest(ResourceUri, Method.POST);
            request.AddBody(WrapModel(model));
            return RequestService.ExecuteRequest<T>(request);
        }

        public virtual T Save(T model)
        {
            if (model == null)
                throw new ArgumentNullException("model");
            return ResolveIdFromModel(model) == null ? Create(model) : Update(model);
        }

        public virtual T Update(T model)
        {
            if (model == null)
                throw new ArgumentNullException("model");

            var request = CreateRequest(ResourceItemUri, Method.PUT);
            request.AddBody(WrapModel(model));
            request.AddParameter("id", ResolveIdFromModel(model), ParameterType.UrlSegment);
            return RequestService.ExecuteRequest<T>(request);
        }
    }
}
