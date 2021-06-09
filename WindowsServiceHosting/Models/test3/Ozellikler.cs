using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Ozellikler
    {
        public Ozellikler()
        {
            Degerler = new HashSet<Degerler>();
        }

        public Guid Oid { get; set; }
        public string OzellikAdi { get; set; }
        public string OlusturanKisi { get; set; }
        public bool? Web { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string EngOzellikAdi { get; set; }
        public bool? EngWeb { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual ICollection<Degerler> Degerler { get; set; }
    }
}
