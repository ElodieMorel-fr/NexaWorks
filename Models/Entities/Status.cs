using System.ComponentModel.DataAnnotations;

namespace NexaWorks.Models.Entities
{
    public class Status
    {
        public int StatusId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; } = null!;
    }
}
