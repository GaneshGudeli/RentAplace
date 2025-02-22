using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentAplace.Data.Entities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required, ForeignKey(nameof(Sender))]
        public int SenderId { get; set; }

        [Required, ForeignKey(nameof(Receiver))]
        public int ReceiverId { get; set; }

        [Required, MaxLength(1000)]
        public string MessageText { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;

        // Navigation Properties
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}
