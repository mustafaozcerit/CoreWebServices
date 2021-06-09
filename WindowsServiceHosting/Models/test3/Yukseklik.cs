using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Yukseklik
    {
        public Yukseklik()
        {
            Aksesuar = new HashSet<Aksesuar>();
            Urunler = new HashSet<Urunler>();
        }

        public Guid Oid { get; set; }
        public string Yuksek { get; set; }
        public bool? Web { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual ICollection<Aksesuar> Aksesuar { get; set; }
        public virtual ICollection<Urunler> Urunler { get; set; }
    }
}
