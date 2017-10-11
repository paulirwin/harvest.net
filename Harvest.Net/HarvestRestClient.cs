using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using Harvest.Net.Resources;
using Newtonsoft.Json;
using Refit;
using Harvest.Net.Utils;

namespace Harvest.Net
{
    public class HarvestRestClient : IHarvestRestClient, IDisposable
    {
        private readonly HttpClient _httpClient;

        public HarvestRestClient(int accountId, string accessToken)
        {
            var refitSettings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new SnakeCaseContractResolver()
                }
            };

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.harvestapp.com"),
                DefaultRequestHeaders =
                {
                    Authorization = new AuthenticationHeaderValue("Bearer", accessToken),
                    UserAgent =
                    {
                        new ProductInfoHeaderValue("harvest.net", Assembly.GetExecutingAssembly().GetName().Version.ToString())
                    }
                }
            };

            _httpClient.DefaultRequestHeaders.Add("Harvest-Account-Id", accountId.ToString());

            Companies = RestService.For<ICompanyApi>(_httpClient, refitSettings);
            Clients = RestService.For<IClientApi>(_httpClient, refitSettings);
        }

        public IClientApi Clients { get; }

        public ICompanyApi Companies { get; }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
