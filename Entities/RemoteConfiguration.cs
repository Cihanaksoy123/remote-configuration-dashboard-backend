using RemoteConfigurationDashboardBackEnd.Enums;
using RemoteConfigurationDashboardBackEnd.Entities.Common;

namespace RemoteConfigurationDashboardBackEnd.Entities
{
    public class RemoteConfiguration: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public EnumValueType Type { get; set; }


        public int FilterId { get; set; }
        public virtual RemoteConfigurationFilter Filter { get; set; }
    }
}
