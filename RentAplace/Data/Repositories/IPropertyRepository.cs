using RentAplace.Data.Entities;

namespace RentAplace.Data.Repositories
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetAllProperties();
        Property GetPropertyById(int id);
        void AddProperty(Property property);
        void UpdateProperty(Property property);
        void DeleteProperty(int id);
    }
}
