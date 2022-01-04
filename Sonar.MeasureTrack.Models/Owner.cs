namespace Sonar.MeasureTrack.Models
{
    public class Owner
    {
        public long OwnerId { get; set; }
        public bool IsActive { get; set; } = true;
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }
        public string OwnerNotes { get; set; }
    }
}
