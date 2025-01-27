using System.ComponentModel.DataAnnotations;

namespace RemoteConfigurationDashboardBackEnd.Entities.Common
{
    public abstract class BaseEntity : AuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}
