using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Harvest.Net.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Clock
    {
        [EnumMember(Value = "12h")]
        TwelveHour,

        [EnumMember(Value = "24h")]
        TwentyFourHour
    }
}
