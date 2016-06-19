using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqUDbCreator
{
    class DbInitializer : DropCreateDatabaseIfModelChanges<UniqUDbContex>
    {
        protected override void Seed(UniqUDbContex context)
        {
            context.CategoryOfClothes.Add();
            context.StylesOfClothes.Add();
            context.TypesOfClothes.Add();


            base.Seed(context);
        }
    }
}
