namespace Harvest.Net.Containers
{
    public abstract class ListContainerBase
    {
        public int PerPage { get; set; }

        public int TotalEntries { get; set; }

        public int TotalPages { get; set; }

        public int? NextPage { get; set; }

        public int? PreviousPage { get; set; }

        public int Page { get; set; }
    }
}
