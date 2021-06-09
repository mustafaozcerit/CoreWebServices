using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Address
    {
        public Address()
        {
            PartyAddress1Navigation = new HashSet<Party>();
            PartyAddress2Navigation = new HashSet<Party>();
        }

        public Guid Oid { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipPostal { get; set; }
        public Guid? Country { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual ICollection<Party> PartyAddress1Navigation { get; set; }
        public virtual ICollection<Party> PartyAddress2Navigation { get; set; }
    }
}
