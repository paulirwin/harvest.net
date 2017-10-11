using System.Threading.Tasks;
using Harvest.Net.Models;
using Refit;

namespace Harvest.Net.Resources
{
    public interface ICompanyApi
    {
        [Get("/v2/company")]
        Task<Company> GetAsync();
    }
}
