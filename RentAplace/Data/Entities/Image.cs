using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentAplace.Data.Entities
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        [Required, ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }

        [Required, MaxLength(500)]
        public string ImageUrl { get; set; }

        public bool IsPrimary { get; set; } = false; // Main image for the property

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;

        // Navigation Property
        public Property Property { get; set; }

    }
}
