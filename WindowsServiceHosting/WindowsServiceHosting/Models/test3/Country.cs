using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string PhoneCode { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
