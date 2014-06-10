using System;

namespace TradeGeckoApi.Serialization
{
    public class RootPropertyNameAttribute : Attribute
    {
        private readonly string _pluralName;

        private readonly string _singularName;

        public RootPropertyNameAttribute(string pluralName, string singularName)
        {
            _pluralName = pluralName;
            _singularName = singularName;
        }

        public string PluralName
        {
            get { return _pluralName; }
        }

        public string SingularName
        {
            get { return _singularName; }
        }
    }
}
