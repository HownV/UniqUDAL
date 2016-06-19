using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqUDbCreator.Configurations;
using UniqUDbCreator.DbEntities;

namespace UniqUDbCreator
{
    class UniqUDbContex : DbContext
    {
        public UniqUDbContex() : base("name=\"UniqUStringConnection\"")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<CategoryOfClothing> CategoryOfClothes { get; set; }
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
