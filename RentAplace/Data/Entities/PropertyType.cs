using System.ComponentModel.DataAnnotations;

namespace RentAplace.Data.Entities
{
    public class PropertyType
    {
        [Key]
        public int PropertyTypeId { get; set; }

        [Required, MaxLength(50)]
        public string TypeName { get; set; } // House, Apartment, Villa, etc.

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;

        // Navigation Properties
        public ICollection<Property> Properties { get; set; } = new List<Property>();
    }
}
