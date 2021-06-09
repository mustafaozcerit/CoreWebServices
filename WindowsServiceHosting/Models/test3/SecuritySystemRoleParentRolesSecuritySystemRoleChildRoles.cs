﻿using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles
    {
        public Guid? ChildRoles { get; set; }
        public Guid? ParentRoles { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual SecuritySystemRole ChildRolesNavigation { get; set; }
        public virtual SecuritySystemRole ParentRolesNavigation { get; set; }
    }
}
