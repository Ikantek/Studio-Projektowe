using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace GymManager.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime? GymPass { get; set; }
        public string Password { get; set; }

        public virtual Role Role { get; set; }

        [NotMapped] public string FullName => $"{Name} {Surname}";
    }
}
