using System.ComponentModel.DataAnnotations;

namespace Sonar.MeasureTrack.Models
{
    public class Metric
    {
        [Key]
        public long MetricId { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public long SectionId { get; set; }

        [Required]
        public string SectionName { get; set; }

        [Required]
        public string SectionDescription { get; set; }

        [Required]
        public string MeasurementUnits { get; set; } // mm or kg

        public double? MeasurementMinimum { get; set; }
        public double? MeasurementMaximum { get; set; }

        [Required]
        public bool IsPassFail { get; set; } = false;
    }
}
