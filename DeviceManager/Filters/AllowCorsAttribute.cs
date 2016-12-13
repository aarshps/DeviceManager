using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace DeviceManager.Filters
{
    public class AllowCorsAttribute : Attribute, ICorsPolicyProvider
    {
        private CorsPolicy policy ;

        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (policy == null)
            {
                var retval = new CorsPolicy();
                retval.AllowAnyHeader = true;
                retval.AllowAnyMethod = true;
                retval.AllowAnyOrigin = true;
                retval.SupportsCredentials = true;
                policy = retval;
            }
            return Task.FromResult(policy);
        }
    }

}