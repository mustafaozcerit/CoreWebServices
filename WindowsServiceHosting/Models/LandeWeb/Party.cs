using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Party
    {
        public Party()
        {
            PhoneNumber = new HashSet<PhoneNumber>();
            Task = new HashSet<Task>();
        }

        public Guid Oid { get; set; }
        public byte[] Photo { get; set; }
        public Guid? Address1 { get; set; }
        public Guid? Address2 { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }

        public virtual Address Address1Navigation { get; set; }
        public virtual Address Address2Navigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumber { get; set; }
        public virtual ICollection<Task> Task { get; set; }
    }
}
