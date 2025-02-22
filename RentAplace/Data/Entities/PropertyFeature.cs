using System.ComponentModel.DataAnnotations.Schema;

namespace RentAplace.Data.Entities
{
    public class PropertyFeature
    {
        [ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }

        [ForeignKey(nameof(Feature))]
        public int FeatureId { get; set; }

        // Navigation Properties
        public Property Property { get; set; }
        public Feature Feature { get; set; }
    }
}
