using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sonar.MeasureTrack.Models
{
    [Index(nameof(SailNumber), IsUnique = true)]
    public class Measurement
    {
        [Key]
        public long MeasurementId { get; set; }

        public long? OwnerId { get; set; }

        [Required]
        public int SailNumber { get; set; }

        [Required]
        public string Builder { get; set; }

        [Required]
        public string SerialNumber { get; set; }

        [Required]
        public string Status { get; set; } = "Unapproved";

        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

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
