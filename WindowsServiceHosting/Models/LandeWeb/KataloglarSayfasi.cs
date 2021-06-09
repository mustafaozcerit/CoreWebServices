using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class KataloglarSayfasi
    {
        public KataloglarSayfasi()
        {
            Kataloglar = new HashSet<Kataloglar>();
        }

        public Guid Oid { get; set; }
        public string Baslik { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string BaslikEng { get; set; }
        public string OlusturanKisi { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? Index { get; set; }
        public bool? Web { get; set; }
        public bool? EngWeb { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual ICollection<Kataloglar> Kataloglar { get; set; }
    }
}
