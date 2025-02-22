
using Microsoft.EntityFrameworkCore;
using RentAplace.Data.Entities;
using RentAplace.Data;
using System.Collections.Generic;
using System.Linq;

namespace RentAplace.Data.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly AppDbContext _context;

        public PropertyRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Property> GetAllProperties()
        {
            return _context.Properties.ToList();
        }

        public Property GetPropertyById(int id)
        {
            return _context.Properties.FirstOrDefault(p=> p.PropertyId == id);
        }

        public void AddProperty(Property property)
        {
            _context.Properties.Add(property);
            _context.SaveChanges();
        }

        // ✅ Fix: Mark entity as modified before saving
        public void UpdateProperty(Property property)
        {
            _context.Properties.Update(property);  // Added this line
            _context.SaveChanges();
        }

        public void DeleteProperty(int id)
        {
            var property = _context.Properties.Find(id);
            if (property != null)
            {
                _context.Properties.Remove(property);
                _context.SaveChanges();
            }
        }
    }
}




















//using Microsoft.EntityFrameworkCore;
//using RentAplace.Data.Entities;
//using RentAplace.Data;
//namespace RentAplace.Data.Repositories
//{
//    public class PropertyRepository : IPropertyRepository
//    {
//        private readonly AppDbContext _context;

//        public PropertyRepository(AppDbContext context)
//        {
//            _context = context;
//        }


//        public IEnumerable<Property> GetAllProperties()
//        {
//            return _context.Properties.ToList();
//        }

//        public Property GetPropertyById(int id)
//        {
//            return _context.Properties.Find(id);
//        }

//        public void AddProperty(Property property)
//        {
//            _context.Properties.Add(property);
//            _context.SaveChanges();
//        }

//        public void UpdateProperty(Property property)
//        {
//            //_context.Properties.Attach(property);
//            //_context.Entry(property).State = EntityState.Modified;
//            //_context.SaveChanges();
//           // _context.Properties.Update(property);
//            _context.SaveChanges();
//        }

//        public void DeleteProperty(int id)
//        {
//            var property = _context.Properties.Find(id);
//            if (property != null)
//            {
//                _context.Properties.Remove(property);
//                _context.SaveChanges();
//            }
//        }
//            //public async Task<IEnumerable<Property>> GetAllPropertiesAsync()
//            //{
//            //    return await _context.Properties
//            //        .Include(p => p.Owner)
//            //        .Include(p => p.PropertyType)
//            //        .ToListAsync();
//            //}

//            //public async Task<Property?> GetPropertyByIdAsync(int propertyId)
//            //{
//            //    return await _context.Properties
//            //        .Include(p => p.Owner)
//            //        .Include(p => p.PropertyType)
//            //        .FirstOrDefaultAsync(p => p.PropertyId == propertyId);
//            //}

//            //public async Task AddPropertyAsync(Property property)
//            //{
//            //    _context.Properties.Add(property);
//            //    await _context.SaveChangesAsync();
//            //}

//            //public async Task UpdatePropertyAsync(Property property)
//            //{
//            //    _context.Properties.Update(property);
//            //    await _context.SaveChangesAsync();
//            //}

//            //public async Task DeletePropertyAsync(int propertyId)
//            //{
//            //    var property = await _context.Properties.FindAsync(propertyId);
//            //    if (property != null)
//            //    {
//            //        _context.Properties.Remove(property);
//            //        await _context.SaveChangesAsync();
//            //    }
//            //}

//    }
//}
