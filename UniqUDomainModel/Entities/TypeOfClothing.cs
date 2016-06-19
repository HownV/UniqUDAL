using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqUDomainModel.Entities
{
    public class TypeOfClothing
    {
        [Key, MaxLength(50)]
        public string Name { get; set; }
    }
}
