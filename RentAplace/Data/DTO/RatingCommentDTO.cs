namespace RentAplace.Data.DTO
{
    public class RatingCommentDTO
    {
        public int PropertyId { get; set; }

        public int Rating { get; set; } // 1 to 5 stars

        public string Comment { get; set; }
    }
}
