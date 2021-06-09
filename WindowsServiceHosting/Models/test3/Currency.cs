using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Currency
    {
        public Currency()
        {
            FiyatListesi = new HashSet<FiyatListesi>();
        }

        public Guid Oid { get; set; }
        public string Currencies { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<FiyatListesi> FiyatListesi { get; set; }
    }
}
