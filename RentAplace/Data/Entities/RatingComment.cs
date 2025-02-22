using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentAplace.Data.Entities
{
    public class RatingComment
    {
        [Key]
        public int RatingCommentId { get; set; }

        [Required, ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [Required, ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }

        [Required, Range(1, 5)]
        public int Rating { get; set; } // 1 to 5 stars

        [MaxLength(500)]
        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;

        // Navigation Properties
        public User User { get; set; }
        public Property Property { get; set; }
    }
}
