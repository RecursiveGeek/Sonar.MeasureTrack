namespace Sonar.MeasureTrack.Models
{
    public class Section
    {
        public long SectionId { get; set; }
        public bool IsActive { get; set; } = true;
        public int SectionNumber { get; set; }
        public string SectionName { get; set; }
    }
}
