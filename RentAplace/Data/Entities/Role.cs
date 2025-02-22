using System.ComponentModel.DataAnnotations;

namespace RentAplace.Data.Entities
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required, MaxLength(50)]
        public string RoleName { get; set; } // Admin, Owner, Renter, etc.

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;

        // Navigation Properties
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
