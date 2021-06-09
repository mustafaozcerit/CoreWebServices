using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class PhoneNumber
    {
        public Guid Oid { get; set; }
        public string Number { get; set; }
        public Guid? Party { get; set; }
        public string PhoneType { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual Party PartyNavigation { get; set; }
    }
}
