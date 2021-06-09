using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Role
    {
        public Role()
        {
            UserUsersRoleRoles = new HashSet<UserUsersRoleRoles>();
        }

        public Guid Oid { get; set; }

        public virtual RoleBase O { get; set; }
        public virtual ICollection<UserUsersRoleRoles> UserUsersRoleRoles { get; set; }
    }
}
