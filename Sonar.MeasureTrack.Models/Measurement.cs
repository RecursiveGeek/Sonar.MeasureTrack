using System;
using System.Collections.Generic;

namespace Sonar.MeasureTrack.Models
{
    public class Measurement
    {
        public long MeasurementId { get; set; }

        public string Country { get; set; }
        public int SailNumber { get; set; }
        public string Builder { get; set; }
        public string SerialNumber { get; set; }
        public string Status {  get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? MeasurementDate { get; set; }
        public string Measurer { get; set; }
        public string HullColor { get; set; }
        public string WaterlineColor { get; set; }
        public string DeckColor { get; set; }

        public string Notes { get; set; }
        public string Correspondence { get; set; }

        public List<MeasurementMetric> MeasurementMetrics { get; set; }

        public bool? HasKeelGrandfathered { get; set; }
        public bool? HasRudderGrandfathered { get; set; }
        public bool? HasRequiresWeighing { get; set; }
        public bool? HasCorrectorsByFactory { get; set; }
        public bool? HasCertifiedMast { get; set; }
        public bool? HasUnmeasuredMast { get; set; }
        public bool? HasUnmeasuredDeck { get; set; }
        public bool? HasMissingSerialNumber { get; set; }
        public bool? HasMissingColors { get; set; }   
    }
}
