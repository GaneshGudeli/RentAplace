//using RentAplace.Data.Repositories;
//using Microsoft.EntityFrameworkCore;
//using RentAplace.Data.Entities;
//namespace RentAplace.Data.Services
//{
//    public class PropertyService : IPropertyService
//    {
//        private readonly IPropertyRepository _propertyRepository;

//        public PropertyService(IPropertyRepository propertyRepository)
//        {
//            _propertyRepository = propertyRepository;
//        }

//        //public async Task<IEnumerable<Property>> GetAllPropertiesAsync()
//        //{
//        //    return await _propertyRepository.GetAllPropertiesAsync();
//        //}

//        public async Task<Property?> GetPropertyByIdAsync(int propertyId)
//        {
//            return await _propertyRepository.GetPropertyById(propertyId);
//        }

//        public async Task AddPropertyAsync(Property property)
//        {
//            await _propertyRepository.AddPropertyAsync(property);
//        }

//        public async Task UpdatePropertyAsync(Property property)
//        {
//            await _propertyRepository.UpdatePropertyAsync(property);
//        }

//        public async Task DeletePropertyAsync(int propertyId)
//        {
//            await _propertyRepository.DeletePropertyAsync(propertyId);
//        }
//    }
//}
