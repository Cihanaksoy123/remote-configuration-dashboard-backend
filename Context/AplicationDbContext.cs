
using Microsoft.EntityFrameworkCore;
using RemoteConfigurationDashboardBackEnd.Entities;

namespace RemoteConfigurationDashboardBackEnd.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<AuditTrail> AuditTrails { get; set; }
       
        public DbSet<RemoteConfiguration> RemoteConfigurations { get; set; }
        public DbSet<RemoteConfigurationFilter> RemoteConfigurationFilters { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }    
       
    }
}
