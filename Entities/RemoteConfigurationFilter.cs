using RemoteConfigurationDashboardBackEnd.Entities.Common;
using RemoteConfigurationDashboardBackEnd.Enums;

namespace RemoteConfigurationDashboardBackEnd.Entities
{
    public class RemoteConfigurationFilter: BaseEntity
    {
        public string Version { get; set; }
        public int BuildNumber { get; set; }
        public EnumPlatform Platform { get; set; }
        public EnumCountry Country { get; set; }
    }
}
