namespace NexaWorks.Models.Entities
{
    public class Compatibility
    {
        public int ProductVersionId { get; set; }

        public  int OSId { get; set; }

        public ProductVersion ProductVersion { get; set; } = null!;

        public OperatingSystem OperatingSystem { get; set; } = null!;
    }
}
