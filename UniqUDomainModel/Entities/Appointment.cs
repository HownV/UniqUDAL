using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqUDomainModel.Entities
{
    public class Appointment // specific event in specific date with specific set of clothing
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Event Event { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<Clothing> Clothes { get; set; }

        public Appointment()
        {
            Clothes = new List<Clothing>();
        }
    }
}
