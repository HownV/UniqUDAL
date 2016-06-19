using System.Data.Entity;
using UniqUDbManager.Configurations;
using UniqUDomainModel.Entities;

namespace UniqUDbManager
{
    public class UniqUDbContext : DbContext
    {
        public UniqUDbContext() : base("name=UniqUConnectionString")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Clothing> Clothes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<StyleOfClothing> StylesOfClothes { get; set; }
        public DbSet<TypeOfClothing> TypesOfClothes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // for Fluent API in future
            modelBuilder.Configurations.Add(new UserConfig());
        }
    }
}
