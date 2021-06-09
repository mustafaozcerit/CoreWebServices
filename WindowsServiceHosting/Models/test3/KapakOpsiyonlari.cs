using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class KapakOpsiyonlari
    {
        public KapakOpsiyonlari()
        {
            Fotograflar = new HashSet<Fotograflar>();
            KapakOpsiyonDoc = new HashSet<KapakOpsiyonDoc>();
            Taglar = new HashSet<Taglar>();
        }

        public Guid Oid { get; set; }
        public string Opsiyon { get; set; }
        public string OpsiyonKodu { get; set; }
        public string OlusturanKisi { get; set; }
        public bool? Web { get; set; }
        public Guid? Urunler { get; set; }
        public Guid? UrunGrubu { get; set; }
        public Guid? UrunSerisi { get; set; }
        public Guid? UrunAilesi { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Engopsiyon { get; set; }
        public bool? Engweb { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual UrunAilesi UrunAilesiNavigation { get; set; }
        public virtual UrunGrubu UrunGrubuNavigation { get; set; }
        public virtual UrunSerisi UrunSerisiNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
        public virtual ICollection<Fotograflar> Fotograflar { get; set; }
        public virtual ICollection<KapakOpsiyonDoc> KapakOpsiyonDoc { get; set; }
        public virtual ICollection<Taglar> Taglar { get; set; }
    }
}
