using System.ComponentModel.DataAnnotations;

namespace Sonar.MeasureTrack.Models
{
    public class MeasurementMetric
    {
        [Key]
        public long MeasurementMeticId { get; set; }
        
        [Required]
        public long MeasurementId { get; set; }

        [Required]
        public long MetricId { get; set; }

        public int? MeasurementValue { get; set; }
        public bool? HasPassed { get; set; }
    }
}
