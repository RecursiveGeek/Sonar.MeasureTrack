using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sonar.MeasureTrack.Models;

namespace Sonar.MeasureTrack.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        #region Properties
        public DbSet<Metric> Metrics { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<MeasurementMetric> MeasurementMetrics { get; set; }
        #endregion

        #region Constructors
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        #endregion

        #region Events
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Metric>().ToTable("Metric");
            builder.Entity<Measurement>().ToTable("Measurement");
            builder.Entity<MeasurementMetric>().ToTable("Measurement_Metric");
        }
        #endregion
    }
}
