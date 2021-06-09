using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class UrunDegerler
    {
        public Guid Oid { get; set; }
        public string OlusturanKisi { get; set; }
        public string Deger { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public Guid? Urunler { get; set; }
        public Guid? Degerler { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string EngDeger { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }

        public virtual Degerler DegerlerNavigation { get; set; }
        public virtual Urunler UrunlerNavigation { get; set; }
    }
}
