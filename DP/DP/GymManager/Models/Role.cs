using System;
using System.Collections.Generic;

#nullable disable

namespace GymManager.Models
{
    public partial class Role
    {
        public Role()
        {
            InverseParent = new HashSet<Role>();
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }

        public virtual Role Parent { get; set; }
        public virtual ICollection<Role> InverseParent { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
