using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class GizlilikPolitikasi
    {
        public GizlilikPolitikasi()
        {
            Banner = new HashSet<Banner>();
        }

        public Guid Oid { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string EngBaslik { get; set; }
        public string EngAciklama { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual ICollection<Banner> Banner { get; set; }
    }
}
