using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentAplace.Data.Entities
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [Required, ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }

        [Required, ForeignKey(nameof(Status))]
        public int StatusId { get; set; } // FK to Status Table

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        // Navigation Properties
        public User User { get; set; }
        public Property Property { get; set; }
        public Status Status { get; set; }
    }
}
