namespace Sonar.MeasureTrack.Models
{
    public class MeasurementMetric
    {
        public long MeasurementMeticId { get; set; }
        
        public long MeasurementId { get; set; }
        public long MetricId { get; set; }

        public int? MeasurementValue { get; set; }
        public bool? HasPassed { get; set; }
    }
}
