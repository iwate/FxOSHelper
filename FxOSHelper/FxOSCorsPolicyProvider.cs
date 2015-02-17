using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace FxOSHelper
{
    public class FxOSCorsPolicyProvider : ICorsPolicyProvider
    {
        private string[] origins;
        public FxOSCorsPolicyProvider(string[] allowOrigins)
        {
            origins = allowOrigins;
        }
        public FxOSCorsPolicyProvider(string allowOrigin)
        {
            origins = new string[] { allowOrigin };
        }
        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Create a CORS policy.
            var policy = new CorsPolicy
            {
                AllowAnyMethod = true,
                AllowAnyHeader = true
            };

            // Add allowed origins.
            foreach (string origin in origins)
            {
                policy.Origins.Add(origin);
            }
            return Task.FromResult(policy);
        }
    }
}
