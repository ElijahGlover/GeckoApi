using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TradeGeckoApi.Model;

namespace TradeGeckoApi.Serialization
{
    public class ResponseContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            if (!member.DeclaringType.IsGenericType)
                return property;
            
            var declaringType = member.DeclaringType.GetGenericTypeDefinition();
            if (declaringType == typeof(ListResponse<>))
            {
                var type = member.ReflectedType.GenericTypeArguments[0];
                var attr = type.GetCustomAttribute<RootPropertyNameAttribute>(true);

                property.PropertyName = attr.PluralName;
            }

            if (declaringType == typeof(ItemResponse<>))
            {
                var type = member.ReflectedType.GenericTypeArguments[0];
                var attr = type.GetCustomAttribute<RootPropertyNameAttribute>(true);

                property.PropertyName = attr.SingularName;
            }

            return property;
        }
    }
}
