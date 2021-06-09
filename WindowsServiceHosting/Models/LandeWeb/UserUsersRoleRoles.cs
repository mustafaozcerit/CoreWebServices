using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class UserUsersRoleRoles
    {
        public Guid? Roles { get; set; }
        public Guid? Users { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual Role RolesNavigation { get; set; }
        public virtual User UsersNavigation { get; set; }
    }
}
