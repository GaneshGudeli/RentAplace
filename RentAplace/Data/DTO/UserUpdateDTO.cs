namespace RentAplace.Data.DTO
{
    public class UserUpdateDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Will be hashed before saving
    }
}
