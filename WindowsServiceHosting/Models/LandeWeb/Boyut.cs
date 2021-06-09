using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Boyut
    {
        public Boyut()
        {
            Aksesuar = new HashSet<Aksesuar>();
            Urunler = new HashSet<Urunler>();
        }

        public Guid Oid { get; set; }
        public string Derinlik { get; set; }
        public string Genislik { get; set; }
        public bool? Web { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual ICollection<Aksesuar> Aksesuar { get; set; }
        public virtual ICollection<Urunler> Urunler { get; set; }
    }
}
