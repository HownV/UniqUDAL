﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UniqUDomainModel.Entities
{
    [DataContract]
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required, EmailAddress]
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }

        [Required]
        [DataMember]
        public string PasswordHash { get; set; } // encoding == Base64

        [Required]
        public Guid TokenAccess { get; set; }
        
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

        public User(string email, string passwordHash)
        {
            Id = Guid.NewGuid();
            Email = email;
            PasswordHash = passwordHash;
            TokenAccess = Guid.NewGuid();
            IsDeleted = false;

            Clothes = new List<Clothing>();
            Sets = new List<Set>();
            Events = new List<Event>();
            Appointments = new List<Appointment>();
        }
    }
}
