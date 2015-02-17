using System.Net.Http;
using System.Web.Http.Cors;

namespace FxOSHelper
{
    public class FxOSCorsPolicyFactory : ICorsPolicyProviderFactory
    {
        ICorsPolicyProvider provider;
        public FxOSCorsPolicyFactory(string[] allowOrigins)
        {
            provider = new FxOSCorsPolicyProvider(allowOrigins);
        }
        public FxOSCorsPolicyFactory(string allowOrigin)
        {
             provider = new FxOSCorsPolicyProvider(allowOrigin);
        }
        public ICorsPolicyProvider GetCorsPolicyProvider(HttpRequestMessage request)
        {
            return provider;
        }
    }
}
