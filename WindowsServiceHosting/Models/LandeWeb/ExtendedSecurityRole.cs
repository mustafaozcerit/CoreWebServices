using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class ExtendedSecurityRole
    {
        public Guid Oid { get; set; }

        public virtual PermissionPolicyRole O { get; set; }
    }
}
