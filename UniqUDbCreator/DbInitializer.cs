using System.Data.Entity;
using UniqUDomainModel.Entities;

namespace UniqUDbManager
{
    class DbInitializer : DropCreateDatabaseIfModelChanges<UniqUDbContext>
    {
        protected override void Seed(UniqUDbContext context)
        {
            context.StylesOfClothes.Add(new StyleOfClothing() { Name = "Business" });
            context.StylesOfClothes.Add(new StyleOfClothing() { Name = "Casual" });
            context.StylesOfClothes.Add(new StyleOfClothing() { Name = "Classic" });
            context.StylesOfClothes.Add(new StyleOfClothing() { Name = "Ethnic" });
            context.StylesOfClothes.Add(new StyleOfClothing() { Name = "Romantic" });
            context.StylesOfClothes.Add(new StyleOfClothing() { Name = "Sport" });

            context.TypesOfClothes.Add(new TypeOfClothing() { Name = "Blouse" });
            context.TypesOfClothes.Add(new TypeOfClothing() { Name = "Coat" });
            context.TypesOfClothes.Add(new TypeOfClothing() { Name = "Dress" });
            context.TypesOfClothes.Add(new TypeOfClothing() { Name = "Jacket" });
            context.TypesOfClothes.Add(new TypeOfClothing() { Name = "Pants" });
            context.TypesOfClothes.Add(new TypeOfClothing() { Name = "Suit" });
            context.TypesOfClothes.Add(new TypeOfClothing() { Name = "Shoes" });
            context.TypesOfClothes.Add(new TypeOfClothing() { Name = "T-shirt" });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
