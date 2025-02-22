using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RentAplace.Data.Entities
{
    public class RegistrationDTO
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [JsonPropertyName("email")]
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        public string PasswordHash { get; set; }

        public string? ProfileImage { get; set; }

        public int RoleId { get; set; }
    }
}
