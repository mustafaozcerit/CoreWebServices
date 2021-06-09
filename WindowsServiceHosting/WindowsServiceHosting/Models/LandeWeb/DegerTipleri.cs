using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class DegerTipleri
    {
        public DegerTipleri()
        {
            Degerler = new HashSet<Degerler>();
        }

        public Guid Oid { get; set; }
        public string DegerTipi { get; set; }
        public string OlusturanKisi { get; set; }
        public bool? Web { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string EngDegerTipi { get; set; }
        public bool? EngWeb { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual ICollection<Degerler> Degerler { get; set; }
    }
}
