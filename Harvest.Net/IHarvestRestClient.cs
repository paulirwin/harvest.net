using Harvest.Net.Resources;

namespace Harvest.Net
{
    public interface IHarvestRestClient
    {
        IClientApi Clients { get; }

        ICompanyApi Companies { get; }
    }
}
