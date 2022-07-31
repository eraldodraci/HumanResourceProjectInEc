using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<TblUser>();
        }

        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<TblUser> Users { get; set; }
    }
}
