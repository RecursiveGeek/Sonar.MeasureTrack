namespace Sonar.MeasureTrack.Models
{
    public class Setting
    {
        public long SettingId { get; set; }
        public bool IsActive { get; set; } = true;
        public string CertificateVersion { get; set; }
    }
}
