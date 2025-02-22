using RentAplace.Data.Entities;

namespace RentAplace.Data.Repositories
{
    public interface IRatingCommentRepository
    {

        IEnumerable<RatingComment> GetRatingsForProperty(int propertyId);
        RatingComment GetRatingById(int id);
        void AddRating(RatingComment ratingComment);
        void UpdateRating(RatingComment ratingComment);
        void DeleteRating(int id);
    }
}
