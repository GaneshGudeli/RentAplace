using System.ComponentModel.DataAnnotations;

namespace RentAplace.Data.Entities
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }

        [Required, MaxLength(100)]
        public string FeatureName { get; set; } // Example: "WiFi", "Swimming Pool"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Property
        public ICollection<PropertyFeature> PropertyFeatures { get; set; } = new List<PropertyFeature>();
    }
}

