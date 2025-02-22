using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentAplace.Data;
using RentAplace.Data.DTO;
using RentAplace.Data.Entities;
using RentAplace.Data.Repositories;

namespace RentAplace.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RatingCommentsController : ControllerBase
    {
        private readonly IRatingCommentRepository _ratingRepository;

        public RatingCommentsController(IRatingCommentRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        [AllowAnonymous]
        [HttpGet("property/{propertyId}")]
        public IActionResult GetRatingsForProperty(int propertyId)
        {
            var ratings = _ratingRepository.GetRatingsForProperty(propertyId);
            return Ok(ratings);
        }

        // GET: api/RatingComments/5
        [HttpPost]
        public IActionResult AddRating([FromBody] RatingCommentDTO model)
        {
            if (model == null || model.Rating < 1 || model.Rating > 5)
                return BadRequest("Invalid rating data.");

            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim == null) return Unauthorized("Invalid token.");

            var rating = new RatingComment
            {
                PropertyId = model.PropertyId,
                UserId = int.Parse(userIdClaim),
                Rating = model.Rating,
                Comment = model.Comment,
                CreatedAt = DateTime.UtcNow
            };

            _ratingRepository.AddRating(rating);
            return CreatedAtAction(nameof(GetRatingsForProperty), new { propertyId = rating.PropertyId }, rating);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRating(int id, [FromBody] RatingCommentDTO model)
        {
            var rating = _ratingRepository.GetRatingById(id);
            if (rating == null) return NotFound("Rating not found.");

            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim == null || rating.UserId != int.Parse(userIdClaim))
            {
                return Forbid(); 
            }

            rating.Rating = model.Rating;
            rating.Comment = model.Comment;

            _ratingRepository.UpdateRating(rating);
            return Ok(new { message = "Rating updated successfully." });
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteRating(int id)
        {
            var rating = _ratingRepository.GetRatingById(id);
            if (rating == null) return NotFound("Rating not found.");

            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userRoleClaim = User.FindFirst(ClaimTypes.Role)?.Value;

            if (userIdClaim == null || (rating.UserId != int.Parse(userIdClaim) && userRoleClaim != "Admin"))
            {
                return Forbid(); // 403 Forbidden
            }

            _ratingRepository.DeleteRating(id);
            return Ok(new { message = "Rating deleted successfully." });
        }





    }
}
