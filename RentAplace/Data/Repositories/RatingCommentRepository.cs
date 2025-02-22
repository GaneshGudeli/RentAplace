using RentAplace.Data.Entities;

namespace RentAplace.Data.Repositories
{
    public class RatingCommentRepository : IRatingCommentRepository
    {
        private readonly AppDbContext _context;

        public RatingCommentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<RatingComment> GetRatingsForProperty(int propertyId)
        {
            return _context.RatingComments
                           .Where(r => r.PropertyId == propertyId && !r.IsDeleted)
                           .ToList();
        }

        public RatingComment GetRatingById(int id)
        {
            return _context.RatingComments.FirstOrDefault(r => r.RatingCommentId == id && !r.IsDeleted);
        }

        public void AddRating(RatingComment ratingComment)
        {
            _context.RatingComments.Add(ratingComment);
            _context.SaveChanges();
        }

        public void UpdateRating(RatingComment ratingComment)
        {
            _context.RatingComments.Update(ratingComment);
            _context.SaveChanges();
        }

        public void DeleteRating(int id)
        {
            var rating = _context.RatingComments.FirstOrDefault(r => r.RatingCommentId == id);
            if (rating != null)
            {
                rating.IsDeleted = true; // Soft delete
                _context.SaveChanges();
            }
        }
    }
}
