using System.ComponentModel.DataAnnotations;

namespace NexaWorks.Models.Entities
{
    public class ProductVersion
    {
        public int ProductVersionId { get; set; }

        [MaxLength(20)]
        public string VersionNumber { get; set; } = null!;

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public ICollection<Compatibility> Compatibilities { get; set; } = null!;
    }
}
