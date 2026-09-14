using System.ComponentModel.DataAnnotations.Schema;

namespace NexaWorks.Models.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }

        public int ProductVersionId { get; set; }

        [ForeignKey(nameof(OperatingSystem))]
        public int OSId { get; set; }

        public int StatusId { get; set; }

        public DateTime CreationDate { get; set; }

        public string IssueDescription { get; set; } = null!;

        public DateTime? ResolutionDate { get; set; }

        public string? ResolutionDescription { get; set; } = null!;

        public ProductVersion ProductVersion { get; set; } = null!;

        public OperatingSystem OperatingSystem { get; set; } = null!;

        public Status Status { get; set; } = null!;
    }
}
