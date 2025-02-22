using RentAplace.Data.Entities;


namespace RentAplace.Data.Services
{
    public interface IPropertyService
    {

        Task<IEnumerable<Property>> GetAllPropertiesAsync();
        Task<Property?> GetPropertyById(int propertyId);
        Task AddPropertyAsync(Property property);
        Task UpdatePropertyAsync(Property property);
        Task DeletePropertyAsync(int propertyId);
    }
}
