using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class ExtendedSecurityRole
    {
        public Guid Oid { get; set; }

        public virtual PermissionPolicyRole O { get; set; }
    }
}
