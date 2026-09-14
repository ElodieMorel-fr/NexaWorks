using System.ComponentModel.DataAnnotations;

namespace NexaWorks.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public ICollection<ProductVersion> ProductVersions { get; set; } = null!;
    }
}
