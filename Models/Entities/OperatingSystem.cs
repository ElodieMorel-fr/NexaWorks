using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NexaWorks.Models.Entities
{
    public class OperatingSystem
    {        
        public int OSId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public ICollection<Compatibility> Compatibilities { get; set; } = null!;
    }
}
