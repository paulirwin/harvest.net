using System.Collections.Generic;
using Harvest.Net.Models;

namespace Harvest.Net.Containers
{
    public class ClientsContainer : ListContainerBase
    {
        public List<Client> Clients { get; set; }
    }
}
