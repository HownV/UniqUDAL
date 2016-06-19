using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqUDbCreator.DbEntities
{
    public class Set
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Clothing> Clothes { get; set; }

        [NotMapped]
        public int CountOfClothing => Clothes.Count;

        public Set()
        {
            Clothes = new List<Clothing>();
        }
    }
}
