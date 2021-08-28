using io.unlaunch;

namespace Microsoft.eShopWeb.Web.Services
{
    public class UnlaunchService
    {
        private const string CatalogReverseFlag = "catalog_reverse";

        private readonly IUnlaunchClient _client;

        public UnlaunchService(IUnlaunchClient client)
        {
            _client = client;
        }

        public bool IsCatalogReverseFlagEnabled(string userIdentity)
        {
            var variation = _client.GetVariation(CatalogReverseFlag, userIdentity);
            return variation == "on";
        }
    }
}
