using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqUDbCreator.DbEntities;

namespace UniqUDbCreator.Configurations
{
    class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
        }
    }
}
