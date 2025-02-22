using System.ComponentModel.DataAnnotations;

namespace RentAplace.Data.Entities
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }

        [Required, MaxLength(50)]
        public string StatusName { get; set; } // Pending, Confirmed, Cancelled, etc.

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;

        // Navigation Properties
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
