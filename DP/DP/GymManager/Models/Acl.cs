using System;
using System.Collections.Generic;

#nullable disable

namespace GymManager.Models
{
    public enum AclAction:byte
    {
        Reject=0,
        Accept=1
    }

    public partial class Acl
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public int ObjectId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public AclAction Action { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
