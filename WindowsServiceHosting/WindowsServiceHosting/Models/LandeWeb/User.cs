using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class User
    {
        public User()
        {
            UserUsersRoleRoles = new HashSet<UserUsersRoleRoles>();
        }

        public Guid Oid { get; set; }
        public string StoredPassword { get; set; }
        public string UserName { get; set; }
        public bool? ChangePasswordOnFirstLogon { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person O { get; set; }
        public virtual ICollection<UserUsersRoleRoles> UserUsersRoleRoles { get; set; }
    }
}
