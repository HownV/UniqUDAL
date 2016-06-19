using System.Data.Entity.ModelConfiguration;
using UniqUDomainModel.Entities;

namespace UniqUDbManager.Configurations
{
    class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
        }
    }
}
