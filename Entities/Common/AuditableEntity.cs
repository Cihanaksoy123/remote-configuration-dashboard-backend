
namespace RemoteConfigurationDashboardBackEnd.Entities.Common
{
    public abstract class AuditableEntity
    {
        public DateTime CreatedDateUTC { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastUpdatedDateUTC { get; set; }
    }
}
