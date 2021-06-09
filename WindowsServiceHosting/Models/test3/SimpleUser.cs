using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class SimpleUser
    {
        public Guid Oid { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAdministrator { get; set; }
        public bool? ChangePasswordOnFirstLogon { get; set; }
        public string Password { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
