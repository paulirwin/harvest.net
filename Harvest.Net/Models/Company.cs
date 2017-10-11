using System;
using Harvest.Net.Enums;

namespace Harvest.Net.Models
{
    public class Company
    {
        public string BaseUri { get; set; }

        public string FullDomain { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DayOfWeek WeekStartDay { get; set; }

        public bool WantsTimestampTimers { get; set; }

        public TimeFormat TimeFormat { get; set; }

        public string PlanType { get; set; }

        public Clock Clock { get; set; }

        public string DecimalSymbol { get; set; }

        public string ThousandsSeparator { get; set; }

        public string ColorScheme { get; set; }

        public bool ExpenseFeature { get; set; }

        public bool InvoiceFeature { get; set; }

        public bool EstimateFeature { get; set; }

        public bool ApprovalFeature { get; set; }
    }
}
