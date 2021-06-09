using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Renk
    {
        public Renk()
        {
            Urunler = new HashSet<Urunler>();
        }

        public Guid Oid { get; set; }
        public string Renk1 { get; set; }
        public bool? Web { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string EngRenk { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual ICollection<Urunler> Urunler { get; set; }
    }
}
