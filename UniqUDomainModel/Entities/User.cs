using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqUDomainModel.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public string PasswordHash { get; set; } // encoding == Base64

        [Required]
        public Guid AccessToken { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Clothing> Clothes { get; set; }
        public string ClothesHash { get; set; }

        public ICollection<Set> Sets { get; set; }
        public string SetsHash { get; set; }

        public ICollection<Event> Events { get; set; }
        public string EventsHash { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public string AppointmentsHash { get; set; }

        public User()
        {
            Clothes = new List<Clothing>();
            Sets = new List<Set>();
            Events = new List<Event>();
            Appointments = new List<Appointment>();
        }
    }
}
