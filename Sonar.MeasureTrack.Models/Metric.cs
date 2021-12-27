namespace Sonar.MeasureTrack.Models
{
    public class Metric
    {
        public long MetricId { get; set; }
        public int SectionMaster { get; set; }
        public string SectionName { get; set; }
        public string SectionDescription { get; set; }
        public string MeasurementUnits { get; set; } // mm or kg
        public int? MeasurementMinimum { get; set; }
        public int? MeasurementMaximum { get; set; }
        public bool IsPassFail { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}
