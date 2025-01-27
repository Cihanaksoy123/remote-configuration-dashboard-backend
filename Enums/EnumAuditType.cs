using System.ComponentModel.DataAnnotations;

namespace RemoteConfigurationDashboardBackEnd.Enums
{
    public enum EnumAuditType
    {
        [Display(Name = "Hiçbiri")]
        None = 0,
        [Display(Name = "Yeni Kayıt")]
        Create = 1,
        [Display(Name = "Güncelleme")]
        Update = 2,
        [Display(Name = "Silme")]
        Delete = 3
    }
}
