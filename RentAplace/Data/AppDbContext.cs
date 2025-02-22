using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using RentAplace.Data.Entities;

namespace RentAplace.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define DbSets for your entities
        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<PropertyFeature> PropertyFeatures { get; set; }

        public DbSet<RatingComment> RatingComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("rentaplace");

            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            modelBuilder.Entity<Reservation>().HasIndex(r => r.PropertyId);
            modelBuilder.Entity<Reservation>().HasIndex(r => r.UserId);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PropertyFeature>()
                .HasKey(pf => new { pf.PropertyId, pf.FeatureId });

            modelBuilder.Entity<PropertyFeature>()
                .HasOne(pf => pf.Property)
                .WithMany(p => p.PropertyFeatures)
                .HasForeignKey(pf => pf.PropertyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PropertyFeature>()
                .HasOne(pf => pf.Feature)
                .WithMany(f => f.PropertyFeatures)
                .HasForeignKey(pf => pf.FeatureId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Properties)
                .WithOne(p => p.Owner)
                .HasForeignKey(p => p.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            ApplySoftDeleteFilter(modelBuilder);
            ConfigureDecimalPrecision(modelBuilder);

            SeedData(modelBuilder);
        }


        private void SeedData(ModelBuilder modelBuilder)
        {
            // **Seed Roles**
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Admin" },
                new Role { RoleId = 2, RoleName = "Owner" },
                new Role { RoleId = 3, RoleName = "Renter" }
            );

            // **Seed Property Types**
            modelBuilder.Entity<PropertyType>().HasData(
                new PropertyType { PropertyTypeId = 1, TypeName = "Apartment" },
                new PropertyType { PropertyTypeId = 2, TypeName = "Villa" },
                new PropertyType { PropertyTypeId = 3, TypeName = "Studio" },
                new PropertyType { PropertyTypeId = 4, TypeName = "Townhouse" }
            );

            // **Seed Status**
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = 1, StatusName = "Pending" },
                new Status { StatusId = 2, StatusName = "Confirmed" },
                new Status { StatusId = 3, StatusName = "Cancelled" },
                new Status { StatusId = 4, StatusName = "Completed" }
            );

            // **Seed Features**
            modelBuilder.Entity<Feature>().HasData(
                new Feature { FeatureId = 1, FeatureName = "WiFi" },
                new Feature { FeatureId = 2, FeatureName = "Parking" },
                new Feature { FeatureId = 3, FeatureName = "Swimming Pool" },
                new Feature { FeatureId = 4, FeatureName = "Gym" },
                new Feature { FeatureId = 5, FeatureName = "Balcony" },
                new Feature { FeatureId = 6, FeatureName = "Air Conditioning" },
                new Feature { FeatureId = 7, FeatureName = "Heating" },
                new Feature { FeatureId = 8, FeatureName = "Security System" },
                new Feature { FeatureId = 9, FeatureName = "Elevator" },
                new Feature { FeatureId = 10, FeatureName = "Fully Furnished" }
            );


            // **Seed Users**
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    FullName = "Rohit Sharma",
                    Email = "Rohitsharma@gmail.com",
                    PasswordHash = "Rohit123",
                    PhoneNumber = "7657890345",
                    ProfileImage = "profile1.jpg",
                    RoleId = 2 // Owner
                },
                new User
                {
                    UserId = 2,
                    FullName = "virat Kohli",
                    Email = "Viratk123",
                    PasswordHash = "Virat@123",
                    PhoneNumber = "7657894545",
                    ProfileImage = "profile.jpg",
                    RoleId = 3 // Renter
                }
            );

            // **Seed Properties**
            modelBuilder.Entity<Property>().HasData(
                new Property
                {
                    PropertyId = 1,
                    Title = "Luxury Apartment",
                    Description = "A beautiful luxury apartment in the city center.",
                    OwnerId = 1,
                    PropertyTypeId = 1, // Apartment
                    Price = 120.50m,
                    Location = "Bandra, Mumbai"
                },
                new Property
                {
                    PropertyId = 2,
                    Title = "Cozy Villa",
                    Description = "A peaceful villa with a stunning sea view.",
                    OwnerId = 1,
                    PropertyTypeId = 2, // Villa
                    Price = 250.00m,
                    Location = "Diveaghar"
                }
            );



        }









        private void ApplySoftDeleteFilter(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var isDeletedProperty = entityType.FindProperty("IsDeleted");

                if (isDeletedProperty != null && isDeletedProperty.ClrType == typeof(bool))
                {
                    var parameter = Expression.Parameter(entityType.ClrType, "e");
                    var body = Expression.Equal(
                        Expression.Property(parameter, isDeletedProperty.PropertyInfo),
                        Expression.Constant(false));
                    var lambda = Expression.Lambda(body, parameter);

                    modelBuilder.Entity(entityType.ClrType).HasQueryFilter(lambda);
                }
            }
        }

        private void ConfigureDecimalPrecision(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(decimal) || property.ClrType == typeof(decimal?))
                    {
                        property.SetColumnType("decimal(18,2)");
                    }
                }
            }
        }

    




        public DbSet<RentAplace.Data.Entities.Role> Role { get; set; } = default!;
        public DbSet<RentAplace.Data.Entities.PropertyType> PropertyType { get; set; }
    }
}
