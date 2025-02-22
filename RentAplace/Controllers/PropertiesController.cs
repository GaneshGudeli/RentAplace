using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentAplace.Data.Entities;
using RentAplace.Data.Repositories;
using System.Collections.Generic;
using RentAplace.Data.DTO;
using System.Security.Claims;

namespace RentAplace.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertiesController(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetAllProperties()
        {
            var properties = _propertyRepository.GetAllProperties();
            return Ok(properties);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public IActionResult GetPropertyById(int id)
        {
            var property = _propertyRepository.GetPropertyById(id);
            if (property == null)
            {
                return NotFound();
            }
            return Ok(property);
        }

        // Add a new property
        [HttpPost]
        public IActionResult AddProperty([FromBody]  PropertyDTO model)
        {
            if (model == null) return BadRequest("Invalid property data.");

            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim == null) return Unauthorized("Invalid token.");

            var property = new Property
            {
                Title = model.Title,
                Location = model.Location,
                Price = model.Price,
                OwnerId = int.Parse(userIdClaim) 
            };

            _propertyRepository.AddProperty(property);
            return CreatedAtAction(nameof(GetPropertyById), new { id = property.PropertyId }, property);
        }

       
        [HttpPut("{id}")]
        public IActionResult UpdateProperty(int id, [FromBody] Property property)
        {
            if (property == null)
            {
                return BadRequest();
            }

            var existingProperty = _propertyRepository.GetPropertyById(id);
            if (existingProperty == null)
            {
                return NotFound();
            }


            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userRoleClaim = User.FindFirst(ClaimTypes.Role)?.Value;

            if (userIdClaim == null || (property.OwnerId != int.Parse(userIdClaim) && userRoleClaim != "Admin"))
            {
                return Forbid();  
            }





            // Update only the fields that need to change
            existingProperty.Title = property.Title;
            existingProperty.Description = property.Description;
            existingProperty.Location = property.Location;
            existingProperty.Price = property.Price;
            existingProperty.PropertyTypeId = property.PropertyTypeId;
            existingProperty.OwnerId = property.OwnerId;

            _propertyRepository.UpdateProperty(existingProperty);
            return NoContent();
        }

        // Delete a property
        [HttpDelete("{id}")]
        public IActionResult DeleteProperty(int id)
        {
            var existingProperty = _propertyRepository.GetPropertyById(id);
            if (existingProperty == null)
            {
                return NotFound();
            }


            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userRoleClaim = User.FindFirst(ClaimTypes.Role)?.Value;

            if (userIdClaim == null || (existingProperty.OwnerId != int.Parse(userIdClaim) && userRoleClaim != "Admin"))
            {
                return Forbid();  
            }


            _propertyRepository.DeleteProperty(id);
            return NoContent();
        }
    }
}


