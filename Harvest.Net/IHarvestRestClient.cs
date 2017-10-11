using Harvest.Net.Resources;

namespace Harvest.Net
{
    public interface IHarvestRestClient
    {
        IClientApi ClientApi { get; }

        ICompanyApi CompanyApi { get; }
    }
}
