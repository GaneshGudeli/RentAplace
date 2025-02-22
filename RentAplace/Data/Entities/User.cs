using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace RentAplace.Data.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        //[ForeignKey(nameof(Role))]
        //public int RoleId { get; set; } // FK to Role Table


        [ForeignKey(nameof(RoleId))] // Correct FK reference
        public int RoleId { get; set; }


        [Phone, MaxLength(15)]
        public string? PhoneNumber { get; set; }

        [Url, MaxLength(500)]
        public string ProfileImage { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;



        // Navigation Properties
        public Role? Role { get; set; }
        public ICollection<Property> Properties { get; set; } = new List<Property>();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<RatingComment> Ratings { get; set; } = new List<RatingComment>();
        public ICollection<Message> SentMessages { get; set; } = new List<Message>();
        public ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();
    }
}
