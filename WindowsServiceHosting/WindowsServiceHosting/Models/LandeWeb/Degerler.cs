using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Degerler
    {
        public Degerler()
        {
            AksesuarDeger = new HashSet<AksesuarDeger>();
            UrunDegerler = new HashSet<UrunDegerler>();
        }

        public Guid Oid { get; set; }
        public string DegerAdi { get; set; }
        public string Deger { get; set; }
        public Guid? DegerTipi { get; set; }
        public Guid? Ozellikler { get; set; }
        public string OlusturanKisi { get; set; }
        public bool? Web { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public Guid? Urunler { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string EngDegerAdi { get; set; }
        public bool? EngWeb { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual DegerTipleri DegerTipiNavigation { get; set; }
        public virtual Ozellikler OzelliklerNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
        public virtual ICollection<AksesuarDeger> AksesuarDeger { get; set; }
        public virtual ICollection<UrunDegerler> UrunDegerler { get; set; }
    }
}
