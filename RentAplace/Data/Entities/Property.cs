using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RentAplace.Data.Entities
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }

        [Required, ForeignKey(nameof(Owner))]
        public int OwnerId { get; set; }

        [Required, ForeignKey(nameof(PropertyType))]
        public int PropertyTypeId { get; set; } // FK to PropertyType

        [Required, MaxLength(150)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required, MaxLength(200)]
        public string Location { get; set; }

        [Required, Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;


        [JsonIgnore]  // Prevents circular reference
        // Navigation Properties
        public User Owner { get; set; }
        public PropertyType PropertyType { get; set; }
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<RatingComment> Ratings { get; set; } = new List<RatingComment>();
        public ICollection<Image> Images { get; set; } = new List<Image>();
        public ICollection<PropertyFeature> PropertyFeatures { get; set; } = new List<PropertyFeature>();
    }
}
