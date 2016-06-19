using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqUDbCreator.DbEntities
{
    public class Clothing
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public TypeOfClothing Type { get; set; }
        public StyleOfClothing Style { get; set; }
        public CategoryOfClothing Category { get; set; }
        public int? Color { get; set; }
        public string Description { get; set; }
        public ICollection<string> PhotoUrlsList { get; set; }

        public Clothing()
        {
            PhotoUrlsList = new List<string>();
        }
    }
}
